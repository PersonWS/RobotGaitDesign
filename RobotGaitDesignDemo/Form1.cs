using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FormSet;
using System.Threading;
using CommonUtility;
using System.Security.Cryptography;
using LogHelper;
using System.Collections.ObjectModel;
using LZMotor;
using System.Diagnostics.SymbolStore;
using CanFDAdapter;
using System.Reflection;
namespace RobotGaitDesign
{
    public partial class Form1 : Office2007Form
    {
        public static readonly ILogEntity log = LogHelper.EasyLogger.GetLoggerInstance_log4Net("demo");
        CanFDAdapter.CanFDAdapterMain _canFDAdapterMain;
        /// <summary>
        /// 读取电机主动上报数据的队列
        /// </summary>
        private Queue<byte[]> _motorMsgReceivedQueue;
        private readonly object _motorMsgReceivedLock = new object();
        Thread _processQueueThread;
        bool _isProcessQueueThreadContiue = false;
        /// <summary>
        /// 全局lock
        /// </summary>
        private readonly object _lock = new object();
        /// <summary>
        /// 读取电机主动上报数据的队列
        /// </summary>
        private Queue<LZMotorDataMain> _motorReadParameterReceivedQueue = new Queue<LZMotorDataMain>();
        private readonly object _motorReadParameterReceivedQueueLock = new object();
        Thread _motorReadParameterReceivedThread;
        DataTable _dt_motorReadParameterReceived = new DataTable();
        bool _isMotorReadParameterReceivedContiue = false;
        int[] _dgv_motorParameterPosition = new int[2];

        bool _isFilterByMotorId = false;
        /// <summary>
        /// 只显示电机返回数据
        /// </summary>
        bool _isOnlyFeedBackData = false;
        List<byte> _motorIdList = new List<byte>();
        byte _filterID = 0;
        /// <summary>
        /// 显示串口名称 sttring：描述  string2：COM名称
        /// </summary>
        Dictionary<string, string> _comDic;
        /// <summary>
        /// CAN FD的实例信息
        /// </summary>
        CanFDAdapter.CanAdapterEntity _canFDAdapterEntity;
        //保存数据的list
        StringBuilder _sb_txt_showMessage = new StringBuilder();
        StringBuilder _sb_txt_MotorAckData = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
            this.EnableGlass = false;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            _motorMsgReceivedQueue = new Queue<byte[]>();
            Ini();
        }
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

        }
        bool _IsProcessing = false;
        private void btn_analysis_Click(object sender, EventArgs e)
        {
            if (_IsProcessing)
            {
                FormSet.BaseFrmControl.ShowDefalutMessageBox(this, "其他任务正在处理中");
                return;
            }
            List<string> listIDStr = new List<string>();
            List<string> listIData = new List<string>();
            listIDStr = txt_id.Text.Replace("\n", "").Split('\r').ToList();
            listIData = txt_motorData.Text.Replace("\n", "").Split('\r').ToList();
            if (listIDStr.Count == 0 || listIData.Count == 0)
            {
                FormSet.BaseFrmControl.ShowErrorMessageBox(this, "id或data为空");
                return;
            }
            else if (listIDStr.Count != listIData.Count)
            {
                FormSet.BaseFrmControl.ShowErrorMessageBox(this, $"id和data数据长度不一致,listIDStr.Count :{listIDStr.Count}, listIData.Count:{listIData.Count}");
                return;
            }

            try
            {
                _IsProcessing = true;
                AnalysisMotorData(listIDStr, listIData);
            }
            catch (Exception ex)
            {
                BaseFrmControl.ShowErrorMessageBox(this, $"{ex.ToString()}");
                _IsProcessing = false;
            }
        }





        private void AnalysisMotorData(List<string> listIDStr, List<string> listIData)
        {
            //List<byte[]> listID = new List<byte[]>();
            //List<byte[]> listData = new List<byte[]>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < listIDStr.Count; i++)
            {
                LZMotor.ExtendData_ID id = new LZMotor.ExtendData_ID(listIDStr[i]);
                LZMotor.Data_Motor data = new LZMotor.Data_Motor(listIData[i]);
                DataTable dataTable;
                string ret = LZMotor.DataAnalysisHelper.AnalysisData_ReturnString(id, data, out dataTable);

                if (!string.IsNullOrEmpty(ret))
                {
                    sb.Append(ret);
                }
                //ShowMessage($"第{i}行:{ret}");
            }
            ShowMessage(sb.ToString());
            _IsProcessing = false;

        }




        private void ShowMessage(string msg, bool isAppendTimeStamp = true, Enum_Log4Net_RecordLevel level = Enum_Log4Net_RecordLevel.DEBUG)
        {
            if (_sb_txt_showMessage.Length > BaseFrmControl.TextBoxMaxLength * 100)
            {
                lock (_lock)
                {
                    StringBuilder stemp = new StringBuilder();
                    stemp.Append(_sb_txt_showMessage.ToString().Substring(_sb_txt_showMessage.Length / 2));
                    _sb_txt_showMessage = stemp;
                }
            }

            _sb_txt_showMessage.Append(BaseFrmControl.ShowMessageOnTextBox(this, txt_showMessage, msg, isAppendTimeStamp));

            switch (level)
            {
                case Enum_Log4Net_RecordLevel.ALL:
                    break;
                case Enum_Log4Net_RecordLevel.DEBUG:
                    log.Debug(msg);
                    break;
                case Enum_Log4Net_RecordLevel.INFO:
                    log.Info(msg);
                    break;
                case Enum_Log4Net_RecordLevel.WARN:
                    log.Warn(msg);
                    break;
                case Enum_Log4Net_RecordLevel.ERROR:
                    log.Error(msg);
                    break;
                case Enum_Log4Net_RecordLevel.FATAL:
                    log.Fatal(msg);
                    break;
                default:
                    break;
            }
        }

        private void ShowMessage_motorAck(string msg)
        {
            if (_sb_txt_MotorAckData.Length > BaseFrmControl.TextBoxMaxLength * 100)
            {
                lock (_lock)
                {
                    StringBuilder stemp = new StringBuilder();
                    stemp.Append(_sb_txt_MotorAckData.ToString().Substring(_sb_txt_MotorAckData.Length / 2));
                    _sb_txt_MotorAckData = stemp;
                }
            }
            _sb_txt_MotorAckData.Append(BaseFrmControl.ShowMessageOnTextBox(this, txt_MotorAckData, msg, false, true));
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            LogHelper.EasyLogger.ShowDiagnoseForm();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            cmb_comList.Items.Clear();
            // List<string> comList = CanFDAdapter.COM_Server.GetComlist();
            _comDic = CanFDAdapter.COM_Server.GetComPortsWithNames();
            foreach (var item in _comDic)
            {
                cmb_comList.Items.Add(item.Key);
            }
            cmb_comList.SelectedIndex = 0;

        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            int baudRate = 921600;
            if (_canFDAdapterMain != null)
            {
                _canFDAdapterMain.DisConnect();
                _canFDAdapterMain.MessageReceiveEvent -= ComMessageReceived;
            }
            if (cmb_comList.Text.Contains("CH340"))
            {
                baudRate = 921600;
                _canFDAdapterEntity = new CanFDAdapter.CanAdapterEntity(_comDic[cmb_comList.Text], baudRate);
                _canFDAdapterEntity.ChipType = CanFDAdapter.CanAdapterTypeEnum.CH340;
                _canFDAdapterEntity.Description = txt_batchCan.Text;
                _canFDAdapterEntity.ComPort = _comDic[cmb_comList.Text];
                _canFDAdapterMain = new CanFDAdapter.CanFDAdapterMain_RobstrideDynamics(_canFDAdapterEntity);
            }
            else if (cmb_comList.Text.Contains("USB 串行设备"))
            {

                baudRate = 921600;
                _canFDAdapterEntity = new CanFDAdapter.CanAdapterEntity(_comDic[cmb_comList.Text], baudRate);
                _canFDAdapterEntity.ChipType = CanFDAdapter.CanAdapterTypeEnum.ch341;
                _canFDAdapterEntity.Description = txt_batchCan.Text;
                _canFDAdapterEntity.ComPort = _comDic[cmb_comList.Text];
                _canFDAdapterMain = new CanFDAdapter.CanFDAdapterMain_BaoFeng(_canFDAdapterEntity);
            }
            else
            {
                BaseFrmControl.ShowErrorMessageBox(this, "该COM不支持CAN数据收发");
                return;
            }

            if (_canFDAdapterMain.Connect())
            {
                _isProcessQueueThreadContiue = true;
                _canFDAdapterMain.MessageReceiveEvent += ComMessageReceived;
                _processQueueThread = new Thread(ProcessComMessage);
                _processQueueThread.Name = "processMotorData";
                _processQueueThread.IsBackground = true;
                _processQueueThread.Start();
                ShowMessage($"{cmb_comList.Text}   连接成功");
                this.btn_connect.Enabled = false;
                this.btn_disConnect.Enabled = true;

            }
            else
            {
                ShowMessage($"{cmb_comList.Text}   连接失败");
            }

        }


        private void ComMessageReceived(byte[] msg)
        {
            lock (_motorMsgReceivedLock)
            {
                _motorMsgReceivedQueue.Enqueue(msg);

                log.Debug($"ComMessageReceived:{BitConverter.ToString(msg).Replace("-", " ")}");
            }

        }
        private void ProcessComMessage()
        {
            while (_isProcessQueueThreadContiue)
            {
                ProcessComMessageSub();
                Thread.Sleep(100);
            }
        }
        /*************************处理COM接受到的数据主函数****************************/
        private void ProcessComMessageSub()
        {
            List<byte[]> recMsg = null;
            lock (_motorMsgReceivedLock)
            {
                if (_motorMsgReceivedQueue.Count > 0)
                {
                    recMsg = _motorMsgReceivedQueue.ToList();
                    _motorMsgReceivedQueue.Clear();
                }
            }
            if (recMsg != null)
            {
                StringBuilder sb = new StringBuilder();
                StringBuilder sb2 = new StringBuilder();
                foreach (var item in recMsg)
                {

                    LZMotor.ExtendData_ID extendData_ID;
                    LZMotor.Data_Motor data_Motor;
                    List<LZMotorDataMain> lZMotorData = DataAnalysisHelper.AnalysisBytesArrayToCanidAndCandata(_canFDAdapterEntity, item);
                    if (lZMotorData.Count == 0)
                    {
                        //ShowMessage($"报文解析失败，源报文：{BitConverter.ToString(item).Replace('-', ' ')}", true, Enum_Log4Net_RecordLevel.ERROR);
                        log.Error($"报文解析失败，源报文：{BitConverter.ToString(item).Replace('-', ' ')}");
                        continue;
                    }
                    foreach (var item2 in lZMotorData)
                    {
                        try
                        {
                            //当界面显示时，识别到是读取的系统参数，则开始处理，丢到对应的队列中
                            if (_isMotorReadParameterReceivedContiue && item2.ExtendData_ID.CommunicationTypeByte == (byte)Enum_CommunicationType.ReadParameter)
                            {
                                lock (_motorReadParameterReceivedQueueLock)
                                {
                                    _motorReadParameterReceivedQueue.Enqueue(item2);
                                }
                                continue;
                            }
                            _IsProcessing = true;
                            DataTable dtRet;
                            string ret = LZMotor.DataAnalysisHelper.AnalysisData_ReturnString(item2.ExtendData_ID, item2.Data_Motor, out dtRet);

                            //先进行是否是电机数据返回的筛选
                            if (_isOnlyFeedBackData)//只显示电机返回的数据
                            {
                                if (!(item2.ExtendData_ID.CommunicationTypeByte == 0x02 || item2.ExtendData_ID.CommunicationTypeByte == 0X18))
                                {
                                    log.Debug($"id:{item2.ExtendData_ID.MotorIDSend} ,msg:{ret}");
                                    continue;
                                }
                            }
                            if (string.IsNullOrEmpty(ret))//如果没解析就直接显示原始报文
                            {
                                //   byte[] temp2 ;
                                ret = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}: id:{BitConverter.ToString(item2.ExtendData_ID.DataBytes)}, data:{BitConverter.ToString(item2.Data_Motor.DataBytes)}";
                            }
                            else
                            {
                                ret = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}: {ret}";
                            }

                            if (!_isFilterByMotorId)//未通过ID筛选时就智能录入id
                            {

                                if (!_motorIdList.Contains(item2.ExtendData_ID.MotorIDSend))//不包含就录入
                                {
                                    _motorIdList.Add(item2.ExtendData_ID.MotorIDSend);
                                    _motorIdList.Sort();
                                    IniMotorIdFilterCmb(item2.ExtendData_ID.MotorIDSend);
                                }
                                if (dtRet?.TableName == "motorAck" && dtRet?.Rows.Count > 0)
                                {
                                    foreach (DataRow row in dtRet.Rows)
                                    {
                                        sb2.Append($"{row[0]},{row[1]},{row[2]},{row[3]},{row[4]}\r\n");
                                    }
                                }
                                sb.Append(ret + "\r\n");
                                //ShowMessage($"id:{extendData_ID.MotorIDSend} ,msg:{ret}");
                            }
                            else
                            {

                                if (item2.ExtendData_ID.MotorIDSend == (this._filterID))
                                {
                                    if (dtRet?.TableName == "motorAck" && dtRet?.Rows.Count > 0)
                                    {
                                        foreach (DataRow row in dtRet.Rows)
                                        {
                                            sb2.Append($"{row[0]},{row[1]},{row[2]},{row[3]},{row[4]}\r\n");
                                        }
                                    }
                                    sb.Append(ret + "\r\n");
                                }
                                else
                                {
                                    log.Debug($"id:{item2.ExtendData_ID.MotorIDSend} ,msg:{ret}");
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            BaseFrmControl.ShowErrorMessageBox(this, $"{ex.ToString()}");
                            _IsProcessing = false;
                        }
                    }

                }
                if (sb.Length > 0)
                {
                    ShowMessage($"{sb.ToString()}", false);
                }
                if (sb2.Length > 2)
                {
                    ShowMessage_motorAck($"{sb2.ToString().Substring(0, sb2.ToString().Length - 2)}");
                }

            }
        }


        private void ProcessReadParameterMessage()
        {
            while (gp_motorRW.Visible)
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
            lock (_motorReadParameterReceivedQueueLock)
            {
                if (_motorReadParameterReceivedQueue.Count > 0)
                {
                    recMsg = _motorReadParameterReceivedQueue.ToList();
                    _motorReadParameterReceivedQueue.Clear();
                }
            }
            if (recMsg != null)
            {
                foreach (var rec in recMsg)
                {
                    string functionName = BitConverter.ToString(new byte[] { rec.Data_Motor.DataBytes[1], rec.Data_Motor.DataBytes[0] }).Replace("-", "");
                    DataRow[] drs = _dt_motorReadParameterReceived.Select($"电机id='{rec.ExtendData_ID.MotorIDSend}' and 功能码='{functionName}'");
                    Enum_MotorParameter enum_MotorParameter = (Enum_MotorParameter)BitConverter.ToInt16(rec.Data_Motor.DataBytes, 0);
                    object value = MotorParameterValueProcess.GetRealMotorParameterTypeByEnumDescription<object>(enum_MotorParameter, rec.Data_Motor.DataBytes);
                    if (drs.Length > 0)
                    {
                        drs[0]["当前值"] = value?.ToString(); ;
                    }
                    else
                    {
                        DataRow dr = _dt_motorReadParameterReceived.NewRow();
                        dr["电机id"] = rec.ExtendData_ID.MotorIDSend.ToString();
                        dr["功能码"] = functionName;
                        dr["名称"] = Enum.GetName(typeof(Enum_MotorParameter), enum_MotorParameter);
                        dr["当前值"] = value?.ToString();
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



        private void IniMotorIdFilterCmb(object state)
        {
            lock (this)
            {
                this.Invoke(new Action(() =>
                {
                    //this.cmb_idFilter.Items.Add(state.ToString());
                    _motorIdList.Sort();
                    this.cmb_idFilter.Items.Clear();
                    foreach (var item in _motorIdList)
                    {
                        if (item == 253)
                        {
                            continue;
                        }
                        this.cmb_idFilter.Items.Add(item);
                    }
                    this.cmb_idFilter.SelectedIndex = this.cmb_idFilter.Items.Count - 1;
                }));
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btn_disConnect.Enabled = false;
            btn_refresh_Click(sender, e);
        }

        private void btn_disConnect_Click(object sender, EventArgs e)
        {
            _isProcessQueueThreadContiue = false;
            if (_canFDAdapterMain != null)
            {
                _canFDAdapterMain.DisConnect();
                _canFDAdapterMain.MessageReceiveEvent -= ComMessageReceived;
            }
            _canFDAdapterMain = null;
            ShowMessage($"{cmb_comList.Text}   连接已断开");
            this.btn_connect.Enabled = true;
            this.btn_disConnect.Enabled = false;
            this._IsProcessing = false;
        }

        private void chk_filterByMotorID_CheckedChanged(object sender, EventArgs e)
        {
            _isFilterByMotorId = chk_filterByMotorID.Checked;
        }

        private void cmb_idFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this._filterID = Convert.ToByte(cmb_idFilter.Text);
            }
            catch (Exception)
            {

            }

        }

        private void cmb_idFilter_RightToLeftChanged(object sender, EventArgs e)
        {
            try
            {
                this._filterID = Convert.ToByte(cmb_idFilter.Text);
            }
            catch (Exception)
            {

            }
        }

        private void cmb_idFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            BaseFrmControl.KeyPressWithDigital(this, sender, e);
            this._filterID = Convert.ToByte(cmb_idFilter.Text);
        }

        private void chk_OnlyFeedBackData_CheckedChanged(object sender, EventArgs e)
        {
            this._isOnlyFeedBackData = chk_OnlyFeedBackData.Checked;
        }

        private void btn_batchCanAnalysis_Click(object sender, EventArgs e)
        {
            if (_IsProcessing)
            {
                FormSet.BaseFrmControl.ShowDefalutMessageBox(this, "其他任务正在处理中");
                return;
            }
            string content = txt_batchCan.Text.Replace(" ", "").Replace("-", "").Replace("\r", "").Replace("\n", "");
            List<string> listIDStr = new List<string>();
            List<string> listIData = new List<string>();
            for (int i = 0; i < content.Length / 36; i++)
            {
                string str = content.Substring(i * 36, 36);
                if (!str.StartsWith("02") && str.EndsWith("AA"))
                {
                    ShowMessage($"发现异常报文:{str}");
                }
                else
                {
                    listIDStr.Add(str.Substring(2, 8));
                    listIData.Add(str.Substring(18, 16));
                }
            }
            if (listIDStr.Count == 0 || listIData.Count == 0)
            {
                FormSet.BaseFrmControl.ShowErrorMessageBox(this, "id或data为空");
                return;
            }
            else if (listIDStr.Count != listIData.Count)
            {
                FormSet.BaseFrmControl.ShowErrorMessageBox(this, $"id和data数据长度不一致,listIDStr.Count :{listIDStr.Count}, listIData.Count:{listIData.Count}");
                return;
            }

            try
            {
                _IsProcessing = true;
                AnalysisMotorData(listIDStr, listIData);
            }
            catch (Exception ex)
            {
                BaseFrmControl.ShowErrorMessageBox(this, $"{ex.ToString()}");
                _IsProcessing = false;
            }
        }

        private void btn_clearShowMessage_Click(object sender, EventArgs e)
        {
            this.txt_showMessage.Text = "";
        }

        private void btn_saveShowMessage_Click(object sender, EventArgs e)
        {
            string fileName = "MessageData" + DateTime.Now.ToString("MM-dd-HH-mm-ss-fff");
            lock (_lock)
            {
                TextOperate.WriteToFile(fileName, _sb_txt_showMessage.ToString());
                _sb_txt_showMessage.Clear();
            }

            ShowMessage($"保存完成 fileName:{fileName}");
        }

        private void btn_saveMotorAckData_Click(object sender, EventArgs e)
        {
            string fileName = "motorAckData" + DateTime.Now.ToString("MM-dd-HH-mm-ss-fff");
            lock (_lock)
            {
                TextOperate.WriteToFile(fileName, _sb_txt_MotorAckData.ToString());
                _sb_txt_MotorAckData.Clear();
            }
            ShowMessage($"保存完成 fileName:{fileName}");
            txt_MotorAckData.Text = "";
        }
        bool _IsMouseDown = false;
        private void gp_motorRW_MouseDown(object sender, MouseEventArgs e)
        {
            _IsMouseDown = true;
            gp_motorRW.Tag = Control.MousePosition;
        }

        private void gp_motorRW_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (_IsMouseDown)
                {
                    gp_motorRW.Location = new Point(gp_motorRW.Location.X + Control.MousePosition.X - ((Point)gp_motorRW.Tag).X, gp_motorRW.Location.Y + Control.MousePosition.Y - ((Point)gp_motorRW.Tag).Y);
                    gp_motorRW.Tag = Control.MousePosition;
                }
            }
            catch (Exception)
            {

            }
        }

        private void gp_motorRW_MouseUp(object sender, MouseEventArgs e)
        {
            _IsMouseDown = false;
        }

        private void btn_motorRW_Click(object sender, EventArgs e)
        {
            if (_isMotorReadParameterReceivedContiue)
            {
                return;
            }
            _motorReadParameterReceivedThread = new Thread(ProcessReadParameterMessage);
            _motorReadParameterReceivedThread.Name = "ProcessReadParameterMessage";
            _motorReadParameterReceivedThread.IsBackground = true;
            _motorReadParameterReceivedThread.Start();
            gp_motorRW.Visible = true;
            _isMotorReadParameterReceivedContiue = gp_motorRW.Visible;
            //  gp_motorRW.Location = new Point(10, 160);
        }

        private void btn_motorEnable_Click(object sender, EventArgs e)
        {
            if (_canFDAdapterMain == null)
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
                    ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            List<byte[]> sendBufferTemp = LZMotor.LZMotoInteropeMain.W_MotorEnable(listId);//生成发送的buffer
            List<byte[]> sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);
        }

        private void btn_motorUnEnable_Click(object sender, EventArgs e)
        {
            if (_canFDAdapterMain == null)
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
                    ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            List<byte[]> sendBufferTemp = LZMotor.LZMotoInteropeMain.W_MotorDisEnable(listId, false);//生成发送的buffer
            List<byte[]> sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);
        }

        private void btn_motorZero_Click(object sender, EventArgs e)
        {
            if (_canFDAdapterMain == null)
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
                    ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            //更新CSP的期望值
            SaveMotorParameter(Enum_MotorParameter.loc_ref_电机目标角度, (float)0, 0, false);
            //设定零位
            List<byte[]> sendBufferTemp = LZMotor.LZMotoInteropeMain.W_SetMotorZero(listId);//生成发送的buffer
            List<byte[]> sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);
        }

        private void btn_gprw_SetMotorParameter_Click(object sender, EventArgs e)
        {
            if (_canFDAdapterMain == null)
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
            object value = MotorParameterValueProcess.GetRealMotorParameterTypeByEnumDescription<object>(enum_MotorParameter, txt_gprw_SetMotorParameter.Text);
            SaveMotorParameter(enum_MotorParameter, value, 0, chk_gprw_isParameterHold.Checked);
            /*
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
                    ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            //修改值
            List<byte[]> sendBufferTemp = LZMotor.LZMotoInteropeMain.W_SetMotorParameter
                (listId, (Enum_MotorParameter)Enum.Parse(typeof(Enum_MotorParameter), cmb_gprw_SetMotorParameter.Text), float.Parse(txt_gprw_SetMotorParameter.Text));//生成发送的buffer
            List<byte[]> sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);
            //保存值
            sendBufferTemp = LZMotor.LZMotoInteropeMain.W_SetMotorParameterHoldSave
    (listId, (Enum_MotorParameter)Enum.Parse(typeof(Enum_MotorParameter), cmb_gprw_SetMotorParameter.Text), float.Parse(txt_gprw_SetMotorParameter.Text), 2);//生成发送的buffer
            sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);
            */
        }

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
                    ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            //修改值
            List<byte[]> sendBufferTemp = LZMotor.LZMotoInteropeMain.W_SetMotorParameter
                (listId, enum_MotorParameter, parameter);//生成发送的buffer
            List<byte[]> sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);
            if (isNeedHod)
            {
                //保存值
                sendBufferTemp = LZMotor.LZMotoInteropeMain.W_SetMotorParameterHoldSave
        (listId, enum_MotorParameter, parameter, userDefine);//生成发送的buffer
                sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
                str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
                _canFDAdapterMain?.Send(sendBuffer);
            }


        }

        private void labelX9_Click(object sender, EventArgs e)
        {
            gp_motorRW.Visible = false;
            _isMotorReadParameterReceivedContiue = gp_motorRW.Visible;
        }

        private void btn_gprw_getAllMotor_Click(object sender, EventArgs e)
        {
            if (cmb_idFilter.Items.Count == 0)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "当前无id可获取");
                return;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < cmb_idFilter.Items.Count - 1; i++)
            {
                sb.Append($"{cmb_idFilter.Items[i]},");
            }
            sb.Append($"{cmb_idFilter.Items[cmb_idFilter.Items.Count - 1]}");
            txt_gprw_motorID.Text = sb.ToString();
        }

        private void btn_MotorRunModeChange_Click(object sender, EventArgs e)
        {
            if (_canFDAdapterMain == null)
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
                    ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            //修改值
            List<byte[]> sendBufferTemp = LZMotor.LZMotoInteropeMain.W_SetMotorParameter
                (listId, Enum_MotorParameter.run_mode运行模式, (byte)Enum.Parse(typeof(Enum_RunMode), cmb_gprw_motorRunMode.Text));//生成发送的buffer
            List<byte[]> sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);
        }

        private void btn_gprw_EnableMotorReport_Click(object sender, EventArgs e)
        {
            if (_canFDAdapterMain == null)
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
                    ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            List<byte[]> sendBufferTemp = LZMotor.LZMotoInteropeMain.W_MotorReport(listId, true);//生成发送的buffer
            List<byte[]> sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);
        }

        private void btn_gprw_UnEnableMotorReport_Click(object sender, EventArgs e)
        {
            if (_canFDAdapterMain == null)
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
                    ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            List<byte[]> sendBufferTemp = LZMotor.LZMotoInteropeMain.W_MotorReport(listId, false);//生成发送的buffer
            List<byte[]> sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);
        }

        private void btn_gprw_SetMotorReportInterval_Click(object sender, EventArgs e)
        {
            if (_canFDAdapterMain == null)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "调试器未连接");
                return;
            }
            if (string.IsNullOrEmpty(txt_gprw_motorID.Text) || string.IsNullOrEmpty(txt_gprw_SetMotorParameter.Text))
            {
                BaseFrmControl.ShowErrorMessageBox(this, "需输入需要改变参数的电机id，多个id可以用【,】分割。需要输入参数值");
                return;
            }
            SaveMotorParameter(Enum_MotorParameter.EPScan_time, (uint)(uint.Parse(txt_gprw_SetMotorParameter.Text)) / 5, 0, false);
        }

        private void btn_clearMotorError_Click(object sender, EventArgs e)
        {
            if (_canFDAdapterMain == null)
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
                    ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            List<byte[]> sendBufferTemp = LZMotor.LZMotoInteropeMain.W_MotorDisEnable(listId, true);//生成发送的buffer
            List<byte[]> sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);

        }

        private void btn_gprw_motorParameterRead_Click(object sender, EventArgs e)
        {
            if (_canFDAdapterMain == null)
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
                    ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            List<byte[]> sendBufferTemp;
            List<byte[]> sendBuffer;
            string str;

            //读取7016 loc_ref 电机目标位置
            sendBufferTemp = LZMotor.LZMotoInteropeMain.W_ReadMotorParameter(listId, Enum_MotorParameter.loc_ref_电机目标角度);//生成发送的buffer
            sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            str = BitConverter.ToString(sendBuffer?[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);

            //读取loc_kp
            sendBufferTemp = LZMotor.LZMotoInteropeMain.W_ReadMotorParameter(listId, Enum_MotorParameter.loc_kp位置);//生成发送的buffer
            sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            str = BitConverter.ToString(sendBuffer?[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);
            //读取CSP速度限制
            sendBufferTemp = LZMotor.LZMotoInteropeMain.W_ReadMotorParameter(listId, Enum_MotorParameter.limit_spd_csp速度限制);//生成发送的buffer
            sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            str = BitConverter.ToString(sendBuffer?[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);

            //读取电机模式
            sendBufferTemp = LZMotor.LZMotoInteropeMain.W_ReadMotorParameter(listId, Enum_MotorParameter.run_mode运行模式);//生成发送的buffer
            sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            str = BitConverter.ToString(sendBuffer?[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);

            //读取电机错误1
            sendBufferTemp = LZMotor.LZMotoInteropeMain.W_ReadMotorParameter(listId, Enum_MotorParameter.drv_fault);//生成发送的buffer
            sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            str = BitConverter.ToString(sendBuffer?[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);

            //读取电机错误2
            sendBufferTemp = LZMotor.LZMotoInteropeMain.W_ReadMotorParameter(listId, Enum_MotorParameter.drv_temp);//生成发送的buffer
            sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            str = BitConverter.ToString(sendBuffer?[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);

            //读0位设置状态
            sendBufferTemp = LZMotor.LZMotoInteropeMain.W_ReadMotorParameter(listId, Enum_MotorParameter.zero_sta零位状态);//生成发送的buffer
            sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            str = BitConverter.ToString(sendBuffer?[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);

            //读取电流kp
            sendBufferTemp = LZMotor.LZMotoInteropeMain.W_ReadMotorParameter(listId, Enum_MotorParameter.cur_kp电流);//生成发送的buffer
            sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            str = BitConverter.ToString(sendBuffer?[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);

            //读取电流ki
            sendBufferTemp = LZMotor.LZMotoInteropeMain.W_ReadMotorParameter(listId, Enum_MotorParameter.cur_ki电流);//生成发送的buffer
            sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            str = BitConverter.ToString(sendBuffer?[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);

        }

        private void dgv_motorParameter_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                this._dgv_motorParameterPosition[1] = dgv_motorParameter.FirstDisplayedScrollingRowIndex;
            }
            else if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                this._dgv_motorParameterPosition[0] = dgv_motorParameter.HorizontalScrollingOffset;
            }
        }

        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            BaseFrmControl.KeyPressWithDigital(this, sender, e);
        }

        private void txt_gprw_SetMotorParameter_KeyPress(object sender, KeyPressEventArgs e)
        {
            BaseFrmControl.KeyPressWithDigital(this, sender, e, new List<char>() { '.' });
        }

        private void btn_gprw_modifyMotorID_Click(object sender, EventArgs e)
        {
            if (_canFDAdapterMain == null)
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

            List<byte[]> sendBufferTemp = LZMotor.LZMotoInteropeMain.W_MotorEnable(new List<byte>() { sourceID }, destID);//生成发送的buffer
            List<byte[]> sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
            string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
            _canFDAdapterMain?.Send(sendBuffer);
        }

        private void btn_gprw_clearDgv_motorParameter_Click(object sender, EventArgs e)
        {
            dgv_motorParameter.DataSource = null;
            this._dt_motorReadParameterReceived.Clear();
        }

        bool _isScanner = false;
        private void btn_motorScanner_Click(object sender, EventArgs e)
        {
            if (_canFDAdapterMain == null)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "调试器未连接");
                return;
            }
            if (_isScanner)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "正在搜索电机中，请稍后");
                return;
            }
            _isScanner = true;
            Task.Run(() =>
            {
                try
                {
                    LZMotor.ExtendData_ID id = new ExtendData_ID(new byte[8]);
                    LZMotor.Data_Motor data = new Data_Motor(new byte[8]);
                    List<byte[]> sendByte = new List<byte[]>();
                    sendByte.Add(new byte[] { 0, 0, 0xfd, 1, 8, 0, 0, 0, 0, 0, 0, 0, 0 });
                    for (byte i = 1; i < 127; i++)
                    {
                        sendByte[0][3] = i;
                        List<byte[]> sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendByte);
                        string str = BitConverter.ToString(sendBuffer[0]).Replace("-", " ");
                        _canFDAdapterMain?.Send(sendBuffer);
                        Thread.Sleep(2);
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage(ex.ToString());
                }
                finally
                { _isScanner = false; }

            });
        }


    }
}
