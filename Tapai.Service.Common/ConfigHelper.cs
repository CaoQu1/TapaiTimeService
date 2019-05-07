using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapai.Service.Common
{
    /// <summary>
    /// 配置文件帮助类
    /// </summary>
    public class ConfigHelper
    {
        /// <summary>
        /// 获取指定appSetting
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetAppSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
