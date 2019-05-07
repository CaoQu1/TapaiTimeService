using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Tapai.Service
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
            Init();
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new PointService()
            };
            ServiceBase.Run(ServicesToRun);
        }

        /// <summary>
        /// 发生异常
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var log = log4net.LogManager.GetLogger(typeof(Program));
            log.Error(e.ExceptionObject.ToString());
        }


        /// <summary>
        /// 初始化日志
        /// </summary>
        private static void Init()
        {
            try
            {
                string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "log4net.config");
                var config = new FileInfo(logPath);
                if (config.Exists)
                    log4net.Config.XmlConfigurator.ConfigureAndWatch(config);
            }
            catch
            {
                throw new FileNotFoundException("日志配置文件不存在。");
            }
        }
    }
}
