using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanFDAdapter;
using CommonUtility.ThreadHelper;
using DevComponents;
using DevComponents.DotNetBar;
using FormSet;
using LogHelper;
using LZMotor;
using RobotGaitDesign;

namespace RobotGaitDesignDemo
{
    public partial class Frm_MotorInterope : Office2007Form
    {
        Frm_RobotMotorControlMain _baseForm;
        DataTable _dt_motorReadParameterReceived = new DataTable();

        Thread _motorReadParameterReceivedThread;

        public Frm_MotorInterope(Frm_RobotMotorControlMain baseForm)
        {
            InitializeComponent();
            this.EnableGlass = false;
            this._baseForm = baseForm;
            Ini();
        }

        [DllImport("controlcan.dll")]
        static extern UInt32 VCI_FindUsbDevice2(ref VCI_BOARD_INFO pInfo);
        private void Ini()
        {
            foreach (var item in Enum.GetNames(typeof(LZMotor.Enum_RunMode)))
            {
                cmb_gprw_motorRunMode.Items.Add(item);
            }

            cmb_gprw_motorRunMode.SelectedIndex = 0;
            // 同时获取名称和值
            foreach (Enum_MotorParameter value in Enum.GetValues(typeof(Enum_MotorParameter)))
            {
                if ((int)value < 0x7000)
                {
                    continue;
                }
                cmb_gprw_SetMotorParameter.Items.Add(value.ToString());
            }

            cmb_gprw_SetMotorParameter.SelectedIndex = 0;

            _dt_motorReadParameterReceived.Columns.Add("电机id");
            _dt_motorReadParameterReceived.Columns.Add("功能码");
            _dt_motorReadParameterReceived.Columns.Add("名称");
            _dt_motorReadParameterReceived.Columns.Add("当前值");
            //启动参数监听线程
            _motorReadParameterReceivedThread = new Thread(ProcessReadParameterMessage);
            _motorReadParameterReceivedThread.Name = "ProcessReadParameterMessage";
            _motorReadParameterReceivedThread.IsBackground = true;
            _motorReadParameterReceivedThread.Start();

            ThreadPool.SetMinThreads(4,8);
            ThreadPool.SetMaxThreads(8, 16);
        }

        private void ProcessReadParameterMessage()
        {
            while (_baseForm._isMotorReadParameterReceivedContiue)
            {
                ProcessReadParameterMessageSub();
                Thread.Sleep(100);
            }
        }
        /// <summary>
        /// 处理读取到的电机参数
        /// </summary>
        private void ProcessReadParameterMessageSub()
        {
            List<LZMotorDataMain> recMsg = null;
            lock (_baseForm._motorReadParameterReceivedQueueLock)
            {
                if (_baseForm._motorReadParameterReceivedQueue.Count > 0)
                {
                    recMsg = _baseForm._motorReadParameterReceivedQueue.ToList();
                    _baseForm._motorReadParameterReceivedQueue.Clear();
                }
            }
            if (recMsg != null)
            {
                foreach (var rec in recMsg)
                {
                    string functionName = BitConverter.ToString(new byte[] { rec.Data_Motor.DataBytes[1], rec.Data_Motor.DataBytes[0] }).Replace("-", "");
                    DataRow[] drs = _dt_motorReadParameterReceived.Select($"电机id='{rec.ExtendData_ID.MotorIDSend}' and 功能码='{functionName}'");
                    Enum_MotorParameter enum_MotorParameter = (Enum_MotorParameter)BitConverter.ToInt16(rec.Data_Motor.DataBytes, 0);
                    object value = MotorParameterValueProcess.GetRealMotorParameterValueByEnumDescription<object>(enum_MotorParameter, rec.Data_Motor.DataBytes);
                    if (drs.Length > 0)
                    {
                        drs[0]["当前值"] = value.GetType().ToString().Contains("System.Single") ? ((float)value).ToString("0.0000") : value?.ToString();
                    }
                    else
                    {
                        DataRow dr = _dt_motorReadParameterReceived.NewRow();
                        dr["电机id"] = rec.ExtendData_ID.MotorIDSend.ToString();
                        dr["功能码"] = functionName;
                        dr["名称"] = Enum.GetName(typeof(Enum_MotorParameter), enum_MotorParameter);
                        dr["当前值"] = value.GetType().ToString().Contains("System.Single") ? ((float)value).ToString("0.0000") : value?.ToString();
                        _dt_motorReadParameterReceived.Rows.Add(dr);
                    }
                    this.Invoke(new Action(() =>
                    {
                        dgv_motorParameter.DataSource = _dt_motorReadParameterReceived;
                        dgv_motorParameter.Refresh();  // 强制刷新
                    }));
                }
            }
        }


        private void btn_gprw_motorEnable_Click(object sender, EventArgs e)
        {
            if (_baseForm._canFDAdapterMain == null)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "调试器未连接");
                return;
            }

            if (string.IsNullOrEmpty(txt_gprw_motorID.Text))
            {
                BaseFrmControl.ShowErrorMessageBox(this, "需输入需要控制的电机id，多个id可以用【,】分割");
                return;
            }

            List<byte> listId = new List<byte>();
            foreach (var item in txt_gprw_motorID.Text.Replace("\r", "").Replace("\n", "").Replace(" ", "").Split(','))
            {
                byte id;
                if (byte.TryParse(item, out id))
                {
                    listId.Add(id);
                }
                else
                {
                    _baseForm.ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            List<byte[]> sendBufferTemp = LZMotor.LZMotoInteropeMain.W_MotorEnable(listId);//生成发送的buffer
            List<byte[]> sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _baseForm._canFDAdapterMain?.Send(sendBuffer);
        }

        private void btn_gprw_getAllMotor_Click(object sender, EventArgs e)
        {
            if (_baseForm.cmb_idFilter.Items.Count == 0)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "当前无id可获取");
                return;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _baseForm.cmb_idFilter.Items.Count - 1; i++)
            {
                sb.Append($"{_baseForm.cmb_idFilter.Items[i]},");
            }
            sb.Append($"{_baseForm.cmb_idFilter.Items[_baseForm.cmb_idFilter.Items.Count - 1]}");
            txt_gprw_motorID.Text = sb.ToString();
        }

        private void btn_gprw_motorUnEnable_Click(object sender, EventArgs e)
        {
            if (_baseForm._canFDAdapterMain == null)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "调试器未连接");
                return;
            }
            if (string.IsNullOrEmpty(txt_gprw_motorID.Text))
            {
                BaseFrmControl.ShowErrorMessageBox(this, "需输入需要控制的电机id，多个id可以用【,】分割");
                return;
            }
            if (!chk_gprw_motorZeroOffsetProfessional.Checked&& DialogResult.OK != BaseFrmControl.ShowtMessageBoxWithReturn(this, $"确定要将电机[{txt_gprw_motorID.Text}]下使能吗？"))
            {
                return;
            }

            List<byte> listId = new List<byte>();
            foreach (var item in txt_gprw_motorID.Text.Replace("\r", "").Replace("\n", "").Replace(" ", "").Split(','))
            {
                byte id;
                if (byte.TryParse(item, out id))
                {
                    listId.Add(id);
                }
                else
                {
                    _baseForm.ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            List<byte[]> sendBufferTemp = LZMotor.LZMotoInteropeMain.W_MotorDisable(listId, false);//生成发送的buffer
            List<byte[]> sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _baseForm._canFDAdapterMain?.Send(sendBuffer);
        }

        private void btn_gprw_motorZero_Click(object sender, EventArgs e)
        {
            if (_baseForm._canFDAdapterMain == null)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "调试器未连接");
                return;
            }
            if (string.IsNullOrEmpty(txt_gprw_motorID.Text))
            {
                BaseFrmControl.ShowErrorMessageBox(this, "需输入需要控制的电机id，多个id可以用【,】分割");
                return;
            }
            if (!chk_gprw_motorZeroOffsetProfessional.Checked && DialogResult.OK != BaseFrmControl.ShowtMessageBoxWithReturn(this, $"确定要给[{txt_gprw_motorID.Text}]电机置0位吗"))
            {
                return;
            }
            List<byte> listId = new List<byte>();
            foreach (var item in txt_gprw_motorID.Text.Replace("\r", "").Replace("\n", "").Replace(" ", "").Split(','))
            {
                byte id;
                if (byte.TryParse(item, out id))
                {
                    listId.Add(id);
                }
                else
                {
                    _baseForm.ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            //更新CSP的期望值
            SaveMotorParameter(Enum_MotorParameter.loc_ref_电机目标角度, (float)0, 0, false);
            //设定零位
            List<byte[]> sendBufferTemp = LZMotor.LZMotoInteropeMain.W_SetMotorZero(listId);//生成发送的buffer
            List<byte[]> sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _baseForm._canFDAdapterMain?.Send(sendBuffer);
        }
        /// <summary>
        /// 保存电机参数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enum_MotorParameter"></param>
        /// <param name="parameter"></param>
        /// <param name="userDefine"></param>
        /// <param name="isNeedHod"></param>
        private void SaveMotorParameter<T>(Enum_MotorParameter enum_MotorParameter, T parameter, byte userDefine = 0, bool isNeedHod = true)
        {

            List<byte> listId = new List<byte>();
            foreach (var item in txt_gprw_motorID.Text.Replace("\r", "").Replace("\n", "").Replace(" ", "").Split(','))
            {
                byte id;
                if (byte.TryParse(item, out id))
                {
                    listId.Add(id);
                }
                else
                {
                    _baseForm.ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            //修改值
            List<byte[]> sendBufferTemp = LZMotor.LZMotoInteropeMain.W_SetMotorParameter
                (listId, enum_MotorParameter, parameter);//生成发送的buffer
            List<byte[]> sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _baseForm._canFDAdapterMain?.Send(sendBuffer);
            if (isNeedHod)
            {
                //保存值
                sendBufferTemp = LZMotor.LZMotoInteropeMain.W_SetMotorParameterHoldSave
        (listId, enum_MotorParameter, parameter, userDefine);//生成发送的buffer
                sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
                str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
                _baseForm._canFDAdapterMain?.Send(sendBuffer);
            }


        }

        private void btn_MotorRunModeChange_Click(object sender, EventArgs e)
        {
            if (_baseForm._canFDAdapterMain == null)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "调试器未连接");
                return;
            }
            if (string.IsNullOrEmpty(txt_gprw_motorID.Text))
            {
                BaseFrmControl.ShowErrorMessageBox(this, "需输入需要改变参数的电机id，多个id可以用【,】分割。需要输入参数值");
                return;
            }

            List<byte> listId = new List<byte>();
            foreach (var item in txt_gprw_motorID.Text.Replace("\r", "").Replace("\n", "").Replace(" ", "").Split(','))
            {
                byte id;
                if (byte.TryParse(item, out id))
                {
                    listId.Add(id);
                }
                else
                {
                    _baseForm.ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            //修改值
            List<byte[]> sendBufferTemp = LZMotor.LZMotoInteropeMain.W_SetMotorParameter
                (listId, Enum_MotorParameter.run_mode运行模式, (byte)Enum.Parse(typeof(Enum_RunMode), cmb_gprw_motorRunMode.Text));//生成发送的buffer
            List<byte[]> sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _baseForm._canFDAdapterMain?.Send(sendBuffer);
        }

        private void btn_gprw_SetMotorParameter_Click(object sender, EventArgs e)
        {
            if (_baseForm._canFDAdapterMain == null)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "调试器未连接");
                return;
            }
            if (string.IsNullOrEmpty(txt_gprw_motorID.Text) || string.IsNullOrEmpty(txt_gprw_SetMotorParameter.Text))
            {
                BaseFrmControl.ShowErrorMessageBox(this, "需输入需要改变参数的电机id，多个id可以用【,】分割。需要输入参数值");
                return;
            }
            Enum_MotorParameter enum_MotorParameter = (Enum_MotorParameter)Enum.Parse(typeof(Enum_MotorParameter), cmb_gprw_SetMotorParameter.Text);
            object value = MotorParameterValueProcess.GetRealMotorParameterValueByEnumDescription<object>(enum_MotorParameter, txt_gprw_SetMotorParameter.Text);
            SaveMotorParameter(enum_MotorParameter, value, 0, chk_gprw_isParameterHold.Checked);
        }

        private void btn_clearMotorError_Click(object sender, EventArgs e)
        {
            if (_baseForm._canFDAdapterMain == null)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "调试器未连接");
                return;
            }
            if (string.IsNullOrEmpty(txt_gprw_motorID.Text))
            {
                BaseFrmControl.ShowErrorMessageBox(this, "需输入需要控制的电机id，多个id可以用【,】分割");
                return;
            }
            if (!chk_gprw_motorZeroOffsetProfessional.Checked && DialogResult.OK != BaseFrmControl.ShowtMessageBoxWithReturn(this, $"确定要将电机[{txt_gprw_motorID.Text}]下使能并清除故障吗？"))
            {
                return;
            }

            List<byte> listId = new List<byte>();
            foreach (var item in txt_gprw_motorID.Text.Replace("\r", "").Replace("\n", "").Replace(" ", "").Split(','))
            {
                byte id;
                if (byte.TryParse(item, out id))
                {
                    listId.Add(id);
                }
                else
                {
                    _baseForm.ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            List<byte[]> sendBufferTemp = LZMotor.LZMotoInteropeMain.W_MotorDisable(listId, true);//生成发送的buffer
            List<byte[]> sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _baseForm._canFDAdapterMain?.Send(sendBuffer);
        }

        bool _isMotorParameterRead = false;
        private async void btn_gprw_motorParameterRead_Click(object sender, EventArgs e)
        {
            if (_isMotorParameterRead)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "参数读取处理中...");
                return;
            }
            if (_baseForm._canFDAdapterMain == null)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "调试器未连接");
                return;
            }
            if (string.IsNullOrEmpty(txt_gprw_motorID.Text))
            {
                BaseFrmControl.ShowErrorMessageBox(this, "需输入需要控制的电机id，多个id可以用【,】分割");
                return;
            }

            List<byte> listId = new List<byte>();
            foreach (var item in txt_gprw_motorID.Text.Replace("\r", "").Replace("\n", "").Replace(" ", "").Split(','))
            {
                byte id;
                if (byte.TryParse(item, out id))
                {
                    listId.Add(id);
                }
                else
                {
                    _baseForm.ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            _isMotorParameterRead = true;

            var thread = new Thread(() => MotorParameterRead(listId))
            {
                IsBackground = true,
                Priority = ThreadPriority.AboveNormal // 提高优先级
            };
            thread.Start();
            //ThreadPool.QueueUserWorkItem(new WaitCallback((obj) => { MotorParameterRead(listId); ; }));
            //MotorParameterRead(listId);
            //await Task.Run(() =>
            //{
            //    MotorParameterRead(listId);
            //});
        }
        /// <summary>
        /// 读取电机参数的函数
        /// </summary>
        /// <param name="listId"></param>
        private void MotorParameterRead(List<byte> listId)
        
        {
            try
            {
                List<byte[]> sendBufferTemp;
                List<byte[]> sendBuffer;
                string str;
                int threadSleep = 1;
                //读取7016 loc_ref 电机目标位置
                sendBufferTemp = LZMotor.LZMotoInteropeMain.R_ReadMotorParameter(listId, Enum_MotorParameter.loc_ref_电机目标角度);//生成发送的buffer
                sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
                _baseForm._canFDAdapterMain?.Send(sendBuffer);
                ThreadHelper.ThreadSlep_HighPrecisionDelay_Media(threadSleep);
                //读取loc_kp
                sendBufferTemp = LZMotor.LZMotoInteropeMain.R_ReadMotorParameter(listId, Enum_MotorParameter.loc_kp位置环增益);//生成发送的buffer
                sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
                _baseForm._canFDAdapterMain?.Send(sendBuffer);
                ThreadHelper.ThreadSlep_HighPrecisionDelay_Media(threadSleep);
                //读取电流增益
                sendBufferTemp = LZMotor.LZMotoInteropeMain.R_ReadMotorParameter(listId, Enum_MotorParameter.cur_kp电流环增益);//生成发送的buffer
                sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
                _baseForm._canFDAdapterMain?.Send(sendBuffer);
                ThreadHelper.ThreadSlep_HighPrecisionDelay_Media(threadSleep);
                //读取电流积分
                sendBufferTemp = LZMotor.LZMotoInteropeMain.R_ReadMotorParameter(listId, Enum_MotorParameter.cur_ki电流环积分);//生成发送的buffer
                sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
                _baseForm._canFDAdapterMain?.Send(sendBuffer);
                ThreadHelper.ThreadSlep_HighPrecisionDelay_Media(threadSleep);
                //读取速度增益
                sendBufferTemp = LZMotor.LZMotoInteropeMain.R_ReadMotorParameter(listId, Enum_MotorParameter.spd_kp速度环增益);//生成发送的buffer
                sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
                _baseForm._canFDAdapterMain?.Send(sendBuffer);
                ThreadHelper.ThreadSlep_HighPrecisionDelay_Media(threadSleep);
                //读取速度积分
                sendBufferTemp = LZMotor.LZMotoInteropeMain.R_ReadMotorParameter(listId, Enum_MotorParameter.spd_kI速度环积分);//生成发送的buffer
                sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
                _baseForm._canFDAdapterMain?.Send(sendBuffer);
                ThreadHelper.ThreadSlep_HighPrecisionDelay_Media(threadSleep);
                //读取CSP速度限制
                sendBufferTemp = LZMotor.LZMotoInteropeMain.R_ReadMotorParameter(listId, Enum_MotorParameter.limit_spd_csp速度限制);//生成发送的buffer
                sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
                _baseForm._canFDAdapterMain?.Send(sendBuffer);
                ThreadHelper.ThreadSlep_HighPrecisionDelay_Media(threadSleep);
                //读取电机模式
                sendBufferTemp = LZMotor.LZMotoInteropeMain.R_ReadMotorParameter(listId, Enum_MotorParameter.run_mode运行模式);//生成发送的buffer
                sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
                _baseForm._canFDAdapterMain?.Send(sendBuffer);
                ThreadHelper.ThreadSlep_HighPrecisionDelay_Media(threadSleep);

                //读取机械角度
                sendBufferTemp = LZMotor.LZMotoInteropeMain.R_ReadMotorParameter(listId, Enum_MotorParameter.mechPos负载端机械角度);//生成发送的buffer
                sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
                _baseForm._canFDAdapterMain?.Send(sendBuffer);
                ThreadHelper.ThreadSlep_HighPrecisionDelay_Media(threadSleep);
                //读取电机错误1
                sendBufferTemp = LZMotor.LZMotoInteropeMain.R_ReadMotorParameter(listId, Enum_MotorParameter.drv_fault);//生成发送的buffer
                sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
                _baseForm._canFDAdapterMain?.Send(sendBuffer);
                ThreadHelper.ThreadSlep_HighPrecisionDelay_Media(threadSleep);
                //读取电机错误2
                sendBufferTemp = LZMotor.LZMotoInteropeMain.R_ReadMotorParameter(listId, Enum_MotorParameter.drv_temp);//生成发送的buffer
                sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
                _baseForm._canFDAdapterMain?.Send(sendBuffer);
                ThreadHelper.ThreadSlep_HighPrecisionDelay_Media(threadSleep);
                //读0位设置状态
                sendBufferTemp = LZMotor.LZMotoInteropeMain.R_ReadMotorParameter(listId, Enum_MotorParameter.zero_sta零位状态);//生成发送的buffer
                sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
                _baseForm._canFDAdapterMain?.Send(sendBuffer);
                ThreadHelper.ThreadSlep_HighPrecisionDelay_Media(threadSleep);

                //读取零位偏置
                sendBufferTemp = LZMotor.LZMotoInteropeMain.R_ReadMotorParameter(listId, Enum_MotorParameter.add_offset零位偏置);//生成发送的buffer
                sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
                str = BitConverter.ToString(sendBuffer?[0]).Replace("-", " ");
                _baseForm._canFDAdapterMain?.Send(sendBuffer);
                ThreadHelper.ThreadSlep_HighPrecisionDelay_Media(threadSleep);
                //读取上报间隔
                sendBufferTemp = LZMotor.LZMotoInteropeMain.R_ReadMotorParameter(listId, Enum_MotorParameter.EPScan_time);//生成发送的buffer
                sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
                str = BitConverter.ToString(sendBuffer?[0]).Replace("-", " ");
                _baseForm._canFDAdapterMain?.Send(sendBuffer);
            }
            catch (Exception ex)
            {
                _baseForm.ShowMessage($"MotorParameterRead , ex:{ex.ToString()}");
            }
            finally
            {
                _isMotorParameterRead = false;
            }

        }

        private void btn_gprw_SetMotorReportInterval_Click(object sender, EventArgs e)
        {
            if (_baseForm._canFDAdapterMain == null)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "调试器未连接");
                return;
            }
            if (string.IsNullOrEmpty(txt_gprw_motorID.Text))
            {
                BaseFrmControl.ShowErrorMessageBox(this, "需输入需要改变参数的电机id，多个id可以用【,】分割。");
                return;
            }
            if (string.IsNullOrEmpty(txt_gprw_motorReprotInterval.Text))
            {
                BaseFrmControl.ShowErrorMessageBox(this, "需要输入上报间隔的值");
                return;
            }
            uint eps = uint.Parse(txt_gprw_motorReprotInterval.Text) < 10 ? 10 : uint.Parse(txt_gprw_motorReprotInterval.Text);
            SaveMotorParameter(Enum_MotorParameter.EPScan_time, eps / 5 - 2, 0, false);
        }

        private void btn_gprw_UnEnableMotorReport_Click(object sender, EventArgs e)
        {
            if (_baseForm._canFDAdapterMain == null)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "调试器未连接");
                return;
            }
            if (string.IsNullOrEmpty(txt_gprw_motorID.Text))
            {
                BaseFrmControl.ShowErrorMessageBox(this, "需输入需要控制的电机id，多个id可以用【,】分割");
                return;
            }

            List<byte> listId = new List<byte>();
            foreach (var item in txt_gprw_motorID.Text.Replace("\r", "").Replace("\n", "").Replace(" ", "").Split(','))
            {
                byte id;
                if (byte.TryParse(item, out id))
                {
                    listId.Add(id);
                }
                else
                {
                    _baseForm.ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            List<byte[]> sendBufferTemp = LZMotor.LZMotoInteropeMain.W_MotorReport(listId, false);//生成发送的buffer
            List<byte[]> sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _baseForm._canFDAdapterMain?.Send(sendBuffer);
        }

        private void btn_gprw_EnableMotorReport_Click(object sender, EventArgs e)
        {
            if (_baseForm._canFDAdapterMain == null)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "调试器未连接");
                return;
            }
            if (string.IsNullOrEmpty(txt_gprw_motorID.Text))
            {
                BaseFrmControl.ShowErrorMessageBox(this, "需输入需要控制的电机id，多个id可以用【,】分割");
                return;
            }

            List<byte> listId = new List<byte>();
            foreach (var item in txt_gprw_motorID.Text.Replace("\r", "").Replace("\n", "").Replace(" ", "").Split(','))
            {
                byte id;
                if (byte.TryParse(item, out id))
                {
                    listId.Add(id);
                }
                else
                {
                    _baseForm.ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            List<byte[]> sendBufferTemp = LZMotor.LZMotoInteropeMain.W_MotorReport(listId, true);//生成发送的buffer
            List<byte[]> sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _baseForm._canFDAdapterMain?.Send(sendBuffer);
        }

        private void btn_gprw_modifyMotorID_Click(object sender, EventArgs e)
        {
            if (_baseForm._canFDAdapterMain == null)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "调试器未连接");
                return;
            }
            if (string.IsNullOrEmpty(txt_gprw_soureMotorID.Text) || string.IsNullOrEmpty(txt_gprw_destinationMotorID.Text))
            {
                BaseFrmControl.ShowErrorMessageBox(this, $"电机id不可为空");
                return;
            }
            byte sourceID, destID;
            byte.TryParse(txt_gprw_soureMotorID.Text, out sourceID); byte.TryParse(txt_gprw_destinationMotorID.Text, out destID);
            if (sourceID < 0 || sourceID > 127 || destID < 0 || destID > 127)
            {
                BaseFrmControl.ShowErrorMessageBox(this, $"电机id不可小于0或大于127");
                return;
            }

            List<byte[]> sendBufferTemp = LZMotor.LZMotoInteropeMain.W_SetMotorCanID(new List<byte>() { sourceID }, destID);//生成发送的buffer
            List<byte[]> sendBuffer = _baseForm._canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _baseForm._canFDAdapterMain?.Send(sendBuffer);
        }

        private void btn_gprw_motorZeroOffset_Click(object sender, EventArgs e)
        {
            if (_baseForm._canFDAdapterMain == null)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "调试器未连接");
                return;
            }
            if (string.IsNullOrEmpty(txt_gprw_motorID.Text))
            {
                BaseFrmControl.ShowErrorMessageBox(this, "需输入需要改变参数的电机id。");
                return;
            }
            if (string.IsNullOrEmpty(txt_gprw_motorZeroOffset.Text))
            {
                BaseFrmControl.ShowErrorMessageBox(this, "需要输入参数值");
                return;
            }
            if (txt_gprw_motorID.Text.Split(',').Length > 1)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "只允许同时修改1台设备");
                return;
            }
            object value = MotorParameterValueProcess.GetRealMotorParameterValueByEnumDescription<object>(Enum_MotorParameter.add_offset零位偏置, txt_gprw_motorZeroOffset.Text);
            if (!chk_gprw_motorZeroOffsetProfessional.Checked && ((float)value < -5 || (float)value > 5))
            {
                BaseFrmControl.ShowErrorMessageBox(this, "允许修改的角度范围为-5到5度");
                return;
            }
            SaveMotorParameter(Enum_MotorParameter.add_offset零位偏置, (float)((float)value / 114.5916), 0, chk_gprw_isParameterHold.Checked);
        }

        private void btn_gprw_clearDgv_motorParameter_Click(object sender, EventArgs e)
        {
            if (_isMotorParameterRead)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "参数读取中，不允许清除");
                return;
            }
            dgv_motorParameter.DataSource = null;
            this._dt_motorReadParameterReceived.Clear();
        }

        private void txt_gprw_SetMotorParameter_KeyPress(object sender, KeyPressEventArgs e)
        {
            BaseFrmControl.KeyPressWithDigital(this, sender, e, new List<char>() { '.', '-' });
        }

        private void txt_gprw_motorReprotInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            BaseFrmControl.KeyPressWithDigital(this, sender, e);
        }

        private void Frm_MotorInterope_Load(object sender, EventArgs e)
        {
            btn_gprw_getAllMotor_Click(sender, e);
        }

        private void chk_gprw_motorZeroOffsetProfessional_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_gprw_motorZeroOffsetProfessional_MouseUp(object sender, MouseEventArgs e)
        {
            if (!chk_gprw_motorZeroOffsetProfessional.Checked)
            {
                return;
            }
            if (DialogResult.Cancel == BaseFrmControl.ShowtMessageBoxWithReturn(this, $"启用专家模式后，任何操作将不会经过确认，确实要使用专家模式吗？"))
            {
                chk_gprw_motorZeroOffsetProfessional.Checked = false;
                return;
            }
        }
    }
}
