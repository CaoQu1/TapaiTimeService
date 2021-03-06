﻿/**  版本信息模板在安装目录下，可自行修改。
* tp_shop_brush.cs
*
* 功 能： N/A
* 类 名： tp_shop_brush
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/11/12 09:26:32   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;
namespace Tapai.Service.BLL
{
    /// <summary>
    /// tp_shop_brush
    /// </summary>
    public partial class tp_shop_brush
    {
        private readonly Tapai.Service.DAL.tp_shop_brush dal = new Tapai.Service.DAL.tp_shop_brush();
        public tp_shop_brush()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int user_id, string code)
        {
            return dal.Exists(user_id, code);
        }

        /// <summary>
        /// 当月导购是否提醒
        /// </summary>
        /// <param name="user_id"></param>
        /// <param name="scan_time"></param>
        /// <returns></returns>
        public bool ExistsStatistics(int user_id, string scan_time,int number) => dal.ExistsStatistics(user_id, scan_time,number);

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Tapai.Service.Model.tp_shop_brush model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 添加导购通知记录
        /// </summary>
        /// <param name="user_id"></param>
        /// <param name="scan_time"></param>
        /// <param name="is_reminder"></param>
        /// <returns></returns>
        public bool AddStatistics(int user_id, string scan_time,int number, int is_reminder) => dal.AddStatistics(user_id, scan_time, number, is_reminder);

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tapai.Service.Model.tp_shop_brush model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int user_id, string code)
        {

            return dal.Delete(user_id, code);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tapai.Service.Model.tp_shop_brush GetModel(int user_id, string code)
        {

            return dal.GetModel(user_id, code);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tapai.Service.Model.tp_shop_brush> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tapai.Service.Model.tp_shop_brush> DataTableToList(DataTable dt)
        {
            List<Tapai.Service.Model.tp_shop_brush> modelList = new List<Tapai.Service.Model.tp_shop_brush>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tapai.Service.Model.tp_shop_brush model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        ///获取当月导购商家异常地址统计
        public Tuple<DataTable,DataTable> GetCurrentMonthStatistics(string year, string month,string warnText,string cancelText) => dal.GetCurrentMonthStatistics(year, month, warnText, cancelText);
        #endregion  ExtensionMethod
    }
}

