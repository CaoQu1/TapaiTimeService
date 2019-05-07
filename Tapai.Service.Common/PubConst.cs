using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapai.Service.Common
{
    public class PubConst
    {
        /// <summary>
        /// 积分清零时间
        /// </summary>
        public const string INTEGRALCLEARTIME = "intergral_clear_time";

        /// <summary>
        /// 积分清零时间节点
        /// </summary>
        public const string INTEGRALCLEARTIMENODE = "intergral_clear_time_node";

        /// <summary>
        /// 定时
        /// </summary>
        public const string INTERVAL = "interval";

        /// <summary>
        /// 模板消息key
        /// </summary>
        public const string TEMPLATE_MESSAGE_KEY = "remind_template_message";

        /// <summary>
        /// 模板消息内容
        /// </summary>
        public const string TEMPLATE_MESSAGE_KEY_CONTENT = "remind_template_message_content";

        /// <summary>
        /// 每个线程通知的数量
        /// </summary>
        public const string EVERY_COUNT = "every_count";

        /// <summary>
        /// 站点域名
        /// </summary>
        public const string WEBSERVER = "web_server_url";

        /// <summary>
        /// 星期几提醒
        /// </summary>
        public const string REMINDWEEK = "remind_week";

        /// <summary>
        /// 星期几几点提醒
        /// </summary>
        public const string REMINDWEEKHOUR = "remind_week_hour";
    }
}
