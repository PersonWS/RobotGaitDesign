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
using RobotGaitDesignDemo;
using System.Reflection.Emit;
namespace RobotGaitDesign
{
    public partial class RobotMotorControlMain : Office2007Form
    {
        public static readonly ILogEntity log = LogHelper.EasyLogger.GetLoggerInstance_log4Net("demo");
        public CanFDAdapter.CanFDAdapterMain _canFDAdapterMain;
        /// <summary>
        /// 读取电机主动上报数据的队列
        /// </summary>
        private Queue<List<byte[]>> _motorMsgReceivedQueue;
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
        public Queue<LZMotorDataMain> _motorReadParameterReceivedQueue = new Queue<LZMotorDataMain>();
        public readonly object _motorReadParameterReceivedQueueLock = new object();
        Thread _motorReadParameterReceivedThread;
        DataTable _dt_motorReadParameterReceived = new DataTable();
        /// <summary>
        /// 是否继续往子窗体中丢读取到的电机参数
        /// </summary>
        public bool _isMotorReadParameterReceivedContiue = false;
        int[] _dgv_motorParameterPosition = new int[2];
        Frm_MotorInterope _frm_MotorInterope;
        bool _isFilterByMotorId = false;
        /// <summary>
        /// 只显示电机返回数据
        /// </summary>
        bool _isOnlyFeedBackData = false;
        /// <summary>
        /// 只显示向电机写入的数据
        /// </summary>
        bool _isWriteToMotorData = false;
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

        #region 处理txt文本框显示的数据
        public Queue<ShowMessage> _messageQueue = new Queue<ShowMessage>();
        public readonly object _messageQueueLock = new object();
        Thread _messageQueueThread;
        public bool _ismessageQueueThreadContiue = false;
        #endregion

        public RobotMotorControlMain()
        {
            InitializeComponent();
            this.EnableGlass = false;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            _motorMsgReceivedQueue = new Queue<List<byte[]>>();
            Ini();
        }
        private void Ini()
        {

            _dt_motorReadParameterReceived.Columns.Add("电机id");
            _dt_motorReadParameterReceived.Columns.Add("功能码");
            _dt_motorReadParameterReceived.Columns.Add("名称");
            _dt_motorReadParameterReceived.Columns.Add("当前值");

            _ismessageQueueThreadContiue = true;
            //启动显示txt的线程
            _messageQueueThread = new Thread(ShowMessage_Thread);
            _messageQueueThread.Name = "ShowMessage_Thread";
            _messageQueueThread.IsBackground = true;
            _messageQueueThread.Start();

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
                string ret = LZMotor.DataAnalysisHelper.AnalysisAckData_ReturnString(id, data, out dataTable);

                if (!string.IsNullOrEmpty(ret))
                {
                    sb.Append(ret);
                }
                //ShowMessage($"第{i}行:{ret}");
            }
            ShowMessage(sb.ToString());
            _IsProcessing = false;

        }




        public void ShowMessage(string msg, bool isAppendTimeStamp = true, Enum_Log4Net_RecordLevel level = Enum_Log4Net_RecordLevel.DEBUG)
        {
            lock (_messageQueueLock)
            {
                ShowMessage msg1 = new ShowMessage(msg, isAppendTimeStamp, level);
                _messageQueue.Enqueue(msg1);
            }
        }

        public void ShowMessage_sub(List<ShowMessage> msgList)
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
            StringBuilder sb = new StringBuilder();
            foreach (var item in msgList)
            {
                if (item.isAppendTimeStamp)
                {
                    sb.Append($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}: {item.msg} \r\n");

                }
                else
                {
                    sb.Append($"{item.msg} \r\n");
                }
                switch (item.level)
                {
                    case Enum_Log4Net_RecordLevel.ALL:
                        break;
                    case Enum_Log4Net_RecordLevel.DEBUG:
                        log.Debug(item.msg);
                        break;
                    case Enum_Log4Net_RecordLevel.INFO:
                        log.Info(item.msg);
                        break;
                    case Enum_Log4Net_RecordLevel.WARN:
                        log.Warn(item.msg);
                        break;
                    case Enum_Log4Net_RecordLevel.ERROR:
                        log.Error(item.msg);
                        break;
                    case Enum_Log4Net_RecordLevel.FATAL:
                        log.Fatal(item.msg);
                        break;
                    default:
                        break;
                }
            }

            _sb_txt_showMessage.Append(BaseFrmControl.ShowMessageOnTextBox(this, txt_showMessage, sb.ToString(), false));

        }
        private void ShowMessage_Thread()
        {
            while (_ismessageQueueThreadContiue)
            {
                List<ShowMessage> msgList = null;
                lock (_messageQueueLock)
                {
                    if (_messageQueue.Count > 0)
                    {
                        msgList = _messageQueue.ToList();
                        _messageQueue.Clear();
                    }
                }
                if (msgList != null)
                {
                    ShowMessage_sub(msgList);
                }
                Thread.Sleep(200);
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
                _canFDAdapterMain.BusUseageRateEvent -= BusUseageRate;
                _canFDAdapterMain.MessageReceiveEvent -= ComMessageReceived;
                _canFDAdapterMain.DisConnect();
                _canFDAdapterEntity = null;

            }
            if (cmb_comList.Text.Contains("CH340"))
            {
                baudRate = 921600;
                _canFDAdapterEntity = new CanFDAdapter.CanAdapterEntity(_comDic[cmb_comList.Text], baudRate);
                _canFDAdapterEntity.ChipType = CanFDAdapter.CanAdapterTypeEnum.CH340;
                //_canFDAdapterEntity.Description = txt_batchCan.Text;
                _canFDAdapterEntity.ComPort = _comDic[cmb_comList.Text];
                _canFDAdapterMain = new CanFDAdapter.CanFDAdapterMain_RobstrideDynamics(_canFDAdapterEntity);
            }
            else if (cmb_comList.Text.Contains("USB 串行设备"))
            {

                baudRate = 921600;
                _canFDAdapterEntity = new CanFDAdapter.CanAdapterEntity(_comDic[cmb_comList.Text], baudRate);
                _canFDAdapterEntity.ChipType = CanFDAdapter.CanAdapterTypeEnum.ch341;
                //_canFDAdapterEntity.Description = txt_batchCan.Text;
                _canFDAdapterEntity.ComPort = _comDic[cmb_comList.Text];
                _canFDAdapterMain = new CanFDAdapter.CanFDAdapterMain_BaoFeng(_canFDAdapterEntity);
            }
            else
            {
                BaseFrmControl.ShowErrorMessageBox(this, "该COM不支持CAN数据收发");
                return;
            }

            if (_canFDAdapterMain.Connect(500))
            {
                _isProcessQueueThreadContiue = true;
                _canFDAdapterMain.MessageReceiveEvent += ComMessageReceived;
                _canFDAdapterMain.BusUseageRateEvent += BusUseageRate;
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


        private void ComMessageReceived(List<byte[]> msg)
        {
            lock (_motorMsgReceivedLock)
            {
                _motorMsgReceivedQueue.Enqueue(msg);

                // log.Debug($"ComMessageReceived:{BitConverter.ToString(msg).Replace("-", " ")}");
            }

        }
        private void ProcessComMessage()
        {
            while (_isProcessQueueThreadContiue)
            {
                ProcessComMessageSub();
                Thread.Sleep(10);
            }
        }
        /*************************处理COM接受到的数据主函数****************************/
        private void ProcessComMessageSub()
        {
            List<List<byte[]>> recMsg = null;
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
                StringBuilder sb = new StringBuilder();//电机返回值解析
                StringBuilder sb2 = new StringBuilder();//记录电机交互数据
                foreach (var listItem in recMsg)
                {
                    //ShowMessage($"添加条数:{listItem.Count}");
                    foreach (byte[] item in listItem)
                    {
                        LZMotor.ExtendData_ID extendData_ID;
                        LZMotor.Data_Motor data_Motor;
                        LZMotorDataMain lZMotorData = DataAnalysisHelper.AnalysisBytesArrayToCanidAndCandata(_canFDAdapterEntity, item);
                        if (lZMotorData == null)
                        {
                            //ShowMessage($"报文解析失败，源报文：{BitConverter.ToString(item).Replace('-', ' ')}", true, Enum_Log4Net_RecordLevel.ERROR);
                            log.Error($"报文解析失败，源报文：{BitConverter.ToString(item).Replace('-', ' ')}");
                            continue;
                        }
                        try
                        {
                            //当界面显示时，识别到是读取的系统参数，则开始处理，丢到对应的队列中
                            if (_isMotorReadParameterReceivedContiue &&
                                (lZMotorData.ExtendData_ID.CommunicationTypeByte == (byte)Enum_CommunicationType.ReadParameter))
                            {
                                lock (_motorReadParameterReceivedQueueLock)
                                {
                                    _motorReadParameterReceivedQueue.Enqueue(lZMotorData);
                                }
                                continue;
                            }

                            _IsProcessing = true;
                            string ret = "";
                            DataTable dtRet;
                            if (!chk_readMotorVersion.Checked)//如果需要进行版本的读取，则按照以下方式来解析内容
                            {
                                ret = LZMotor.DataAnalysisHelper.AnalysisAckData_ReturnString(lZMotorData.ExtendData_ID, lZMotorData.Data_Motor, out dtRet);
                            }
                            else//启动电机版本判断时执行的函数
                            {
                                if (lZMotorData.Data_Motor.DataBytes[0] == 0 && lZMotorData.Data_Motor.DataBytes[1] == 196 && lZMotorData.Data_Motor.DataBytes[2] == 86)
                                {
                                    ret = LZMotor.DataAnalysisHelper.AnalysisMotorVersionAckData_ReturnString(lZMotorData.ExtendData_ID, lZMotorData.Data_Motor, out dtRet);
                                }
                                else
                                {
                                    ret = LZMotor.DataAnalysisHelper.AnalysisAckData_ReturnString(lZMotorData.ExtendData_ID, lZMotorData.Data_Motor, out dtRet);
                                }
                            }

                            //先进行是否是电机数据返回的筛选
                            if (_isOnlyFeedBackData)//如果只显示电机返回的数据
                            {
                                if (!(lZMotorData.ExtendData_ID.CommunicationTypeByte == (byte)Enum_CommunicationType.AckInformation ||
                                    lZMotorData.ExtendData_ID.CommunicationTypeByte == (byte)Enum_CommunicationType.MotorReportSet))
                                {
                                    log.Debug($"id:{lZMotorData.ExtendData_ID.MotorIDSend} ,msg:{ret}");
                                    continue;
                                }
                            }
                            if (_isWriteToMotorData)//如果只显示写入到电机的参数
                            {
                                if (!(lZMotorData.ExtendData_ID.CommunicationTypeByte == (byte)Enum_CommunicationType.SetParameterUnhold ))
                                {
                                    log.Debug($"id:{lZMotorData.ExtendData_ID.MotorIDSend} ,msg:{ret}");
                                    continue;
                                }
                            }
                            if (chk_analysisFailedShowSocketData.Checked && string.IsNullOrEmpty(ret))//如果没解析就直接显示原始报文
                            {
                                //   byte[] temp2 ;
                                ret = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}: id:{BitConverter.ToString(lZMotorData.ExtendData_ID.DataBytes)}, data:{BitConverter.ToString(lZMotorData.Data_Motor.DataBytes)}";
                            }
                            else
                            {
                                ret = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}: {ret}";
                            }

                            if (!_isFilterByMotorId)//未通过ID筛选时就智能录入id
                            {

                                if (chk_findMotorID.Checked && !_motorIdList.Contains(lZMotorData.ExtendData_ID.MotorIDSend))//智能录入ID代码, 不包含就录入
                                {
                                    _motorIdList.Add(lZMotorData.ExtendData_ID.MotorIDSend);
                                    _motorIdList.Sort();
                                    IniMotorIdFilterCmb(lZMotorData.ExtendData_ID.MotorIDSend);
                                }
                                if (chk_GetMotorAckData.Checked && dtRet?.TableName == "motorAck" && dtRet?.Rows.Count > 0)
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

                                if (lZMotorData.ExtendData_ID.MotorIDSend == (this._filterID) || lZMotorData.ExtendData_ID.MotorIDReceive == (this._filterID))
                                {
                                    if (chk_GetMotorAckData.Checked && dtRet?.TableName == "motorAck" && dtRet?.Rows.Count > 0)
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
                                    log.Debug($"id:{lZMotorData.ExtendData_ID.MotorIDSend} ,msg:{ret}");
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
                if (sb.Length > 4)
                {
                    ShowMessage($"{sb.ToString()}", false);
                }
                if (sb2.Length > 2)
                {
                    ShowMessage_motorAck($"{sb2.ToString().Substring(0, sb2.ToString().Length - 2)}");
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

        private void btn_clearShowMessage_Click(object sender, EventArgs e)
        {
            this.txt_showMessage.Text = "";
            _sb_txt_showMessage.Clear();
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

        private void btn_motorRW_Click(object sender, EventArgs e)
        {
            if (_frm_MotorInterope != null)
            {
                _frm_MotorInterope.BringToFront();
                return;
            }
            _isMotorReadParameterReceivedContiue = true;
            //btn_gprw_getAllMotor_Click(sender, e);
            //_motorReadParameterReceivedThread = new Thread(ProcessReadParameterMessage);
            //_motorReadParameterReceivedThread.Name = "ProcessReadParameterMessage";
            //_motorReadParameterReceivedThread.IsBackground = true;
            //_motorReadParameterReceivedThread.Start();
            //gp_motorRW.Visible = true;
            //_isMotorReadParameterReceivedContiue = gp_motorRW.Visible;
            //  gp_motorRW.Location = new Point(50, 100);
            if (_frm_MotorInterope != null)
            {
                _frm_MotorInterope.BringToFront();
                return;
            }
            _frm_MotorInterope = new Frm_MotorInterope(this);
            _frm_MotorInterope.FormClosed += Frm_MotorInteropeClosedEventHandler;
            _frm_MotorInterope.Size = new Size(865, 550);
            _frm_MotorInterope.StartPosition = FormStartPosition.CenterParent;
            _frm_MotorInterope.Show();

        }

        private void Frm_MotorInteropeClosedEventHandler(object sender, FormClosedEventArgs e)
        {
            _frm_MotorInterope.FormClosed -= Frm_MotorInteropeClosedEventHandler;
            _isMotorReadParameterReceivedContiue = false;
            _frm_MotorInterope = null;
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
            ShowMessage("开始搜索1-127号电机是否存在..");
            _isScanner = true;

            var thread = new Thread(() =>
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
                        //Thread.Sleep(10);
                    }
                    ShowMessage("电机轮询完成！");
                }
                catch (Exception ex)
                {
                    ShowMessage(ex.ToString());
                }
                finally
                { _isScanner = false; }

            })
            {
                IsBackground = true,
                Priority = ThreadPriority.AboveNormal // 提高优先级
            };
            thread.Start();
        }

        bool _isReadMotorVersion = false;
        private void btn_ReadMotorVersion_Click(object sender, EventArgs e)
        {
            if (_isReadMotorVersion)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "版本号读取处理中...");
                return;
            }
            if (_canFDAdapterMain == null)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "调试器未连接");
                return;
            }
            if (cmb_idFilter.Items.Count == 0)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "需先进行电机扫描");
                return;
            }

            List<byte> listId = new List<byte>();
            foreach (var item in cmb_idFilter.Items)
            {
                byte id;
                if (byte.TryParse(item.ToString(), out id))
                {
                    listId.Add(id);
                }
                else
                {
                    ShowMessage($"电机id:{item}错误！", true, Enum_Log4Net_RecordLevel.ERROR);
                }

            }
            _isReadMotorVersion = true;
            List<byte[]> sendBufferTemp;
            List<byte[]> sendBuffer;
            string str;
            try
            {
                chk_readMotorVersion.Checked = true;
                //读取7016 loc_ref 电机目标位置
                sendBufferTemp = LZMotor.LZMotoInteropeMain.R_ReadMotorVersion(listId);//生成发送的buffer
                sendBuffer = _canFDAdapterMain?.CanAdapterDataProcess.GenerateSendMotorData(sendBufferTemp);
                str = BitConverter.ToString(sendBuffer?[0]).Replace("-", " ");
                _canFDAdapterMain?.Send(sendBuffer);
                Thread.Sleep(50);
                Task.Run(() =>
                {
                    Thread.Sleep(1000);
                    this.Invoke(new Action(() => { chk_readMotorVersion.Checked = false; }));
                });
            }
            catch (Exception ex)
            {
                ShowMessage($"btn_ReadMotorVersion_Click , ex:{ex.ToString()}");
            }
            finally
            { _isReadMotorVersion = false; }

        }

        private void BusUseageRate(double rate)
        {
            //log.Debug($"canRate222:{rate}");

            if (this.IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {
                    lab_busUsedRate.Text = $"{(rate * 100).ToString("0.00")}%";
                    //if (rate < 0.3)
                    //{
                    //    lab_busUsedRate.ForeColor = Color.Green;
                    //}
                    //else if (rate < 0.7)
                    //{
                    //    lab_busUsedRate.ForeColor = Color.Yellow;
                    //}
                    //else if (rate < 0.8)
                    //{
                    //    lab_busUsedRate.ForeColor = Color.Red;
                    //}
                    //else
                    //{
                    //    lab_busUsedRate.ForeColor = Color.DarkRed;
                    //    lab_busUsedRate.Text += $"ERROR";
                    //}
                }));
            }

        }

        private void RobotMotorControlMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_canFDAdapterMain != null)
            {
                _canFDAdapterMain.BusUseageRateEvent -= BusUseageRate;
                _canFDAdapterMain.MessageReceiveEvent -= ComMessageReceived;
                _canFDAdapterMain.DisConnect();
                _canFDAdapterEntity = null;

            }
        }

        private void chk_isWriteToMotorData_CheckedChanged(object sender, EventArgs e)
        {
            this._isWriteToMotorData = chk_isWriteToMotorData.Checked;
        }
    }
}
