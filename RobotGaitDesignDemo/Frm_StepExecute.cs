using DevComponents.DotNetBar;
using FormSet;
using LogHelper;
using NPOI.OpenXmlFormats.Dml.Chart;
using NPOI.SS.Formula.Functions;
using RobotGaitDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotGaitDesignDemo
{
    public partial class Frm_StepExecute : Office2007Form
    {
        public static readonly ILogEntity log = LogHelper.EasyLogger.GetLoggerInstance_log4Net("demo");
        Frm_RobotMotorControlMain _baseForm;
        DataTable _dt_motorReadParameterReceived = new DataTable();

        Thread _motorReadParameterReceivedThread;
        /// <summary>
        /// 存储了从excel中读取到的dataset的数据集
        /// </summary>
        DataSet _ds_stepGait = null;
        /// <summary>
        /// 用于存储步态文件的模板
        /// </summary>
        DataTable _dt_stepTemplate = null;

        //DataTable _dt_MotorInfo = null;
        /// <summary>
        /// 用于存储步态文件的dic  string: 步态sheet的名字
        /// </summary>
        Dictionary<string ,DataTable> _dic_dt_stepGait = new Dictionary<string, DataTable> ();

        

        public Frm_StepExecute(Frm_RobotMotorControlMain baseForm)
        {
            this._baseForm = baseForm;
            InitializeComponent();
        }

        private void Ini()
        {
            //_dt_stepTemplate = new DataTable();
            //_dt_stepTemplate.Columns.Add("step");
            //_dt_stepTemplate.Columns["step"].DataType = typeof(int);

        }

        private void btn_readExcel_Click(object sender, EventArgs e)
        { // 创建 OpenFileDialog 实例
            if (_dic_dt_stepGait.Count>0)//清除历史数据
            {
                _dic_dt_stepGait.Clear();
                dgv_motorInfo.DataSource = null;
                dgv_stepInfo.DataSource = null;
                cmb_stepGainName.Items.Clear();
            }
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // 设置对话框属性（可选）
                openFileDialog.Title = "请选择文件";
                openFileDialog.Filter = "Excel 文件|*.xlsx;*.xls|Excel 2007+ (*.xlsx)|*.xlsx|Excel 97-2003 (*.xls)|*.xls|所有文件|*.*";
                openFileDialog.FilterIndex = 1;  // 默认选择第一个筛选器
                openFileDialog.RestoreDirectory = true;  // 恢复上次打开的目录
                openFileDialog.Multiselect = false;      // 是否允许多选

                // 显示对话框并判断用户是否点击"确定"
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                // 获取文件路径
                string filePath = openFileDialog.FileName;
                try
                {
                    _ds_stepGait = ExcelProcess.ParseExcelToDataSet(openFileDialog.FileName);
                    if (_ds_stepGait.Tables.Count==0)
                    {
                        BaseFrmControl.ShowErrorMessageBox(this, "获取到的excel sheet数为0");
                        return;
                    }
                    if (!_ds_stepGait.Tables.Contains("电机设置"))
                    {
                        BaseFrmControl.ShowErrorMessageBox(this, "sheet不含【电机设置】，文件异常！！");
                        return;
                        // 处理数据
                    }
                    dgv_motorInfo.DataSource = AnalysisMotorInfoByExcel(_ds_stepGait.Tables["电机设置"]).Copy();
                    AnalysisStepByExcel(_ds_stepGait);
                }
                catch (Exception ex)
                {
                    BaseFrmControl.ShowErrorMessageBox(this, ex.ToString());
                    _baseForm?.ShowMessage(ex.Message);
                }
            }
        }
        /// <summary>
        /// 从excel中解析电机信息
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        private DataTable AnalysisMotorInfoByExcel( DataTable source)
        {
            if (source.Rows.Count==0)
            {
                return source;
            }
            for (int i = 0; i < source.Columns.Count; i++)
            {
                if (!string.IsNullOrEmpty(source.Rows[0][i].ToString()))
                {
                    source.Columns[i].ColumnName = source.Rows[0][i].ToString();
                }
            }
            source.Rows.RemoveAt(0);//将第一行改为列名
            if (!source.Columns.Contains("version"))
            {
                source.Columns.Add("version");
            }
            if (!source.Columns.Contains("电机编号"))//不含电机编号则直接返回
            {
               return source;
            }
            if (_baseForm==null|| _baseForm._dic_MotorBaseInfo==null)
            {
                return source;
            }
            foreach (var item  in _baseForm._dic_MotorBaseInfo)
            {
                DataRow[] drs = source.Select($"电机编号='{item.Key}' ");
                if (drs.Length>0)
                {
                    foreach (var item2 in drs)
                    {
                        item2["version"] = item.Value.Version;
                    }
                }
            }
            return source;
        }


        /// <summary>
        /// 解析excel中使用的步态数据
        /// </summary>
        /// <param name="ds"></param>
        private void AnalysisStepByExcel(DataSet ds)
        {
            if (ds.Tables.Count<2)
            {
                BaseFrmControl.ShowErrorMessageBox(this, "获取到的excel sheet数小于2，无法解析步态");
                return;
            }
            for (int i = 1; i < ds.Tables.Count; i++)
            {
                DataTable dt1 = ds.Tables[i];
                //变更列名为excel第一行的字段值

                if (dt1.Rows.Count < 2)
                {
                    BaseFrmControl.ShowErrorMessageBox(this, $"TableName:{dt1.TableName} ,row<2，无法解析步态");
                    return;
                }
                for (int j = dt1.Columns.Count-1; j >0; j--)//移除暂时不用的列
                {
                    if (dt1.Rows[0][j].ToString().Contains("增量")|| dt1.Rows[0][j].ToString().Contains("速度"))//移除非关键列
                    {
                        dt1.Columns.Remove(dt1.Columns[j].ColumnName);
                    }
                }
                try//将第一行的值变为列名
                {
                    for (int j = 0; j < dt1.Columns.Count; j++)
                    {
                        if (!string.IsNullOrEmpty(dt1.Rows[0][j].ToString()))
                        {
                            dt1.Columns[j].ColumnName = dt1.Rows[0][j].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    log.Error($"sheet :{dt1.TableName} ，解析失败，存在同名或者为空的列名");
                    continue;
                }
                //对应电机的ID

                dt1.Rows.RemoveAt(0);//去掉第一行
                _dic_dt_stepGait.Add(dt1.TableName, dt1.Copy());
            }
            this.Invoke(new Action(() =>
            {
                cmb_stepGainName.Items.Clear();
                foreach (var item in _dic_dt_stepGait)
                {
                    cmb_stepGainName.Items.Add(item.Key);
                }
                if (cmb_stepGainName.Items.Count>0)
                {
                    cmb_stepGainName.SelectedIndex = 0;
                }

            }));

        }

        private void cmb_stepGainName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dic_dt_stepGait.Keys.Contains(cmb_stepGainName.Text))
            {
                dgv_stepInfo.DataSource = _dic_dt_stepGait[cmb_stepGainName.Text].Copy();
            }
            else
            {
                log.Error($"sheet :{cmb_stepGainName.Text} ，未找到对应的数据");
            }
        }
    }
}
