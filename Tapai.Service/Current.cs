﻿using Dos.Common;
using Dos.WeChat;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tapai.Service.Common;

namespace Tapai.Service
{
    public class Current
    {
        #region Field
        private ILog log;
        private Task task;
        private CancellationToken cancellationToken;
        private CancellationTokenSource cancellationTokenSource;
        private static Lazy<Current> lazy = new Lazy<Current>(() => new Current());
        private BLL.dt_point_log bll_point;
        private BLL.dt_property bll_property;
        private DateTime opreate_time = DateTime.Now;
        private static string formart_message = ConfigHelper.GetAppSetting(PubConst.TEMPLATE_MESSAGE_KEY_CONTENT);
        private static string template_id = ConfigHelper.GetAppSetting(PubConst.TEMPLATE_MESSAGE_KEY);
        private static string web_server_url = ConfigHelper.GetAppSetting(PubConst.WEBSERVER);
        private int index = 1;
        #endregion

        #region Property
        /// <summary>
        /// 单例
        /// </summary>
        public static Current Instance => lazy.Value;

        /// <summary>
        /// 获取时间间隔（分）
        /// </summary>
        private static int Interval
        {
            get
            {
                var interval = ConfigHelper.GetAppSetting(PubConst.INTERVAL);
                return !string.IsNullOrEmpty(interval) ? int.Parse(interval) : 0;
            }
        }

        /// <summary>
        /// 消息内容模板
        /// </summary>
        #endregion

        #region Method
        /// <summary>
        /// ctor
        /// </summary>
        private Current()
        {
            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;
            log = LogManager.GetLogger(typeof(Current));
            bll_point = new BLL.dt_point_log();
            bll_property = new BLL.dt_property();
        }

        /// <summary>
        /// 积分清零任务
        /// </summary>
        /// <param name="cancellationToken"></param>
        private void RunReset(CancellationToken cancellationToken)
        {
            try
            {
                while (true)
                {
                    try
                    {
                        if (cancellationToken.IsCancellationRequested)
                        {
                            log.Info("RunReset=>取消任务!");
                            break;
                        }
                        opreate_time = bll_property.GetUpdateTime("");
                        var dateTime = DateTime.Now;
                        var clear_time = bll_property.GetUpdateTime(PubConst.INTEGRALCLEARTIME);
                        var clear_time_node = bll_property.GetUpdateTime(PubConst.INTEGRALCLEARTIMENODE);
                        if (DateTime.Compare(dateTime, clear_time) == 0)
                        {
                            if (index == 1)
                            {
                                log.Info($"积分清零开始：{clear_time},当前线程ID：{Thread.CurrentThread.ManagedThreadId}");
                                index++;
                            }
                            #region 积分清零
                            RunTask((dr) =>
                             {
                                 if (dr["surplus"] != null && dr["point"] != null)
                                 {
                                     var surplus = dr["surplus"].ToString();
                                     var point = dr["point"].ToString();
                                     if (int.TryParse(surplus, out int _surplus) && int.TryParse(point, out int _point) && _surplus >= _point)//剩余积分大于清零的积分
                                     {
                                         var update_result = bll_point.UpdateUserPoint(new Model.dt_point_log
                                         {
                                             user_id = int.Parse(dr["user_id"].ToString()),
                                             add_time = DateTime.Now,
                                             area_attr = -1,
                                             remark = $"清零{clear_time_node.ToString("yyyy-MM-dd HH:mm:ss")}前的积分!",
                                             rest_value = 0,
                                             state = 0,
                                             value = -_point,
                                             type = 8,
                                             user_name = dr["user_name"].ToString()
                                         });
                                         log.Info($"清零结果：用户=>{dr["user_name"]},清零积分=>{point},结果=>{update_result}");
                                     }
                                 }
                             });
                            #endregion
                        }
                        Thread.Sleep(0);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        /// <summary>
        /// 积分清零通知任务
        /// </summary>
        /// <param name="cancellationToken"></param>
        private void RunNotice(CancellationToken cancellationToken)
        {
            try
            {
                while (true)
                {
                    try
                    {
                        if (cancellationToken.IsCancellationRequested)
                        {
                            log.Info("RunNotice=>取消任务!");
                            break;
                        }
                        opreate_time = bll_property.GetUpdateTime("");
                        var dateTime = DateTime.Now;
                        var clear_time = bll_property.GetUpdateTime(PubConst.INTEGRALCLEARTIME);
                        var clear_time_node = bll_property.GetUpdateTime(PubConst.INTEGRALCLEARTIMENODE);
                        if (dateTime >= opreate_time && dateTime.DayOfWeek == (DayOfWeek)int.Parse(ConfigHelper.GetAppSetting(PubConst.REMINDWEEK)) && dateTime.Hour >= int.Parse(ConfigHelper.GetAppSetting(PubConst.REMINDWEEKHOUR)))
                        {
                            log.Info($"发送积分清零通知开始：{dateTime},当前线程ID：{Thread.CurrentThread.ManagedThreadId}");
                            #region 发送积分清零通知
                            RunTask((dr) =>
                            {
                                var wechat = new WeChatParam();
                                if (dr["user_name"] != null && dr["point"] != null)
                                {
                                    wechat.ToUser = dr["user_name"].ToString();
                                    wechat.Data = new Dictionary<string, string>
                              {
                                                { "first","积分到期提醒通知"},
                                                { "keyword1",""},
                                                { "keyword2",$"{dateTime.ToString("yyyy-MM-dd HH:mm:ss")}"},
                                                { "keyword3",string.Format(formart_message,clear_time_node.Year,clear_time_node.Month,clear_time_node.Day,clear_time.Year,clear_time.Month,clear_time.Day,dr["point"])},
                                                { "remark",""}
                              };
                                    wechat.Url = web_server_url;
                                    wechat.TemplateId = template_id;
                                    log.Info($"推送数据：用户=>{dr["user_name"]},清零积分=>{dr["point"]}");
                                    var result = Message.SendTemplate(wechat);
                                    log.Info("推送结果：" + JSON.ToJSON(result));
                                }
                                else
                                {
                                    log.Info("未获取到用户或积分~~");
                                }
                            });
                            #endregion
#if DEBUG
                        Thread.Sleep(TimeSpan.FromMinutes(Interval));
#else
                            Thread.Sleep(TimeSpan.FromHours(Interval));
#endif
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }

            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        /// <summary>
        /// 运行子任务
        /// </summary>
        /// <param name="clear_time"></param>
        /// <param name="clear_time_node"></param>
        /// <param name="dateTime"></param>
        /// <param name="action"></param>
        private async void RunTask(Action<DataRow> action)
        {
            var total = bll_point.GetNotUsePointCount();
            var every = ConfigHelper.GetAppSetting(PubConst.EVERY_COUNT);
            if (int.TryParse(every, out int everycount))
            {
                int thread_count = total / everycount;
                var is_divide = (total % everycount) == 0;
                if (!is_divide)
                {
                    thread_count += 1;
                }
                for (int i = 0; i < thread_count; i++)
                {
                    await Task.Run(() =>
                      {
                          var dt = bll_point.GetNotUserPoint(i, everycount);
                          if (dt != null && dt.Rows.Count > 0)
                          {
                              //log.Info($"线程：{i},实际数量：{dt.Rows.Count}");
                              foreach (DataRow dr in dt.Rows)
                              {
                                  action(dr);
                              }
                          }
                      });
                }
            }
        }

        /// <summary>
        /// 开启定时任务
        /// </summary>
        public void Start()
        {
            try
            {
                task = Task.Factory.StartNew(() =>
                {
                    try
                    {
                        var task1 = Task.Run(() => RunReset(cancellationToken));
                        var task2 = Task.Run(() => RunNotice(cancellationToken));
                        Task.WaitAll(task1, task2);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }).ContinueWith(result =>
             {
                 if (result.Exception != null)
                 {
                     log.Error(result.Exception.Message, result.Exception);
                 }
             });
                log.Info("Start=>开启定时任务!");
                //task.Wait();//阻塞线程，等待完成，捕获异常。
            }
            catch (AggregateException ex)
            {
                log.Error(ex.Message, ex);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        /// <summary>
        /// 定时任务取消
        /// </summary>
        public void Stop()
        {
            try
            {
                if (cancellationTokenSource != null)
                {
                    cancellationTokenSource.Cancel();
                    task = null;
                    log.Info("Stop=>任务已被取消!");
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }
        #endregion
    }
}