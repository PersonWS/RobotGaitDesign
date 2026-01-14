using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
namespace FormSet
{
    static class AppConfigSetData
    {
        static string _motorID;
        static string _motorType;
        static string _motorVersion;
        static bool isShowLockLog = false;
        static bool isShowBusinessLog = false;
        static bool isShowRunLog = false;
        /// <summary>
        /// 显示锁定和解锁对象的日志
        /// </summary>
        public static bool IsShowLockLog
        {
            get { return AppConfigSetData.isShowLockLog; }
            set { AppConfigSetData.isShowLockLog = value; }
        }


        /// <summary>
        /// 显示锁定和解锁对象的日志
        /// </summary>
        public static bool IsShowBusinessLog
        {
            get { return AppConfigSetData.isShowBusinessLog; }
            set { AppConfigSetData.isShowBusinessLog = value; }
        }


        /// <summary>
        /// 显示锁定和解锁对象的日志
        /// </summary>
        public static bool IsShowRunLog
        {
            get { return AppConfigSetData.isShowRunLog; }
            set { AppConfigSetData.isShowRunLog = value; }
        }

        public static string MotorID { get => _motorID; set { _motorID = value; WriteDataToConfig("MotorID", value); } }
        public static string MotorType { get => _motorType; set { _motorType = value; WriteDataToConfig("MotorType", value); } }

        public static string MotorVersion { get => _motorVersion; set { _motorVersion = value; WriteDataToConfig("MotorVersion", value); } }

        /// <summary>
        /// 向配置文件写入数据
        /// </summary>
        /// <param name="keyName"></param>
        /// <param name="valueToWrite"></param>
        /// <returns></returns>
        public static bool WriteDataToConfig(string keyName, string valueToWrite)
        {
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            return WriteDataToConfig(config, keyName, valueToWrite);

        }

        public static bool WriteDataToConfig(Configuration config, string keyName, string valueToWrite)
        {
            try
            {
                if (config.AppSettings.Settings.AllKeys.Contains(keyName))
                {
                    config.AppSettings.Settings[keyName].Value = valueToWrite;
                }
                else
                {
                    config.AppSettings.Settings.Add(keyName, valueToWrite);
                }
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        static AppConfigSetData()
        {

            if (ConfigurationManager.AppSettings["MotorID"] != null)
            {
                _motorID = ConfigurationManager.AppSettings["MotorID"].ToString();
            }
            if (ConfigurationManager.AppSettings["MotorType"] != null)
            {
                _motorType = ConfigurationManager.AppSettings["MotorType"].ToString();
            }
            if (ConfigurationManager.AppSettings["MotorVersion"] != null)
            {
                _motorVersion = ConfigurationManager.AppSettings["MotorVersion"].ToString();
            }
            if (ConfigurationManager.AppSettings["isShowRunLog"] != null)
            {
                isShowRunLog = ConfigurationManager.AppSettings["isShowRunLog"].ToString().ToLower() == "true" ? true : false;
            }
            if (ConfigurationManager.AppSettings["isShowBusinessLog"] != null)
            {
                isShowBusinessLog = ConfigurationManager.AppSettings["isShowBusinessLog"].ToString().ToLower() == "true" ? true : false;
            }

        }



    }
}
