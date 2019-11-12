﻿/**  版本信息模板在安装目录下，可自行修改。
* tp_shop_operate.cs
*
* 功 能： N/A
* 类 名： tp_shop_operate
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/10/9 13:56:54   N/A    初版
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
    /// tp_shop_operate
    /// </summary>
    public partial class tp_shop_operate
    {
        private readonly Tapai.Service.DAL.tp_shop_operate dal = new Tapai.Service.DAL.tp_shop_operate();
        public tp_shop_operate()
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
        public bool Exists(int id)
        {
            return dal.Exists(id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tapai.Service.Model.tp_shop_operate model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tapai.Service.Model.tp_shop_operate model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            return dal.Delete(id);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tapai.Service.Model.tp_shop_operate GetModel(int id)
        {

            return dal.GetModel(id);
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
        public List<Tapai.Service.Model.tp_shop_operate> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tapai.Service.Model.tp_shop_operate> DataTableToList(DataTable dt)
        {
            List<Tapai.Service.Model.tp_shop_operate> modelList = new List<Tapai.Service.Model.tp_shop_operate>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tapai.Service.Model.tp_shop_operate model;
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
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex, out int total)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex, out total);
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
        ///取消商家的导购功能
        public bool UpdateDealer(int user_id) => dal.UpdateDealer(user_id);
        #endregion  ExtensionMethod
    }
}
