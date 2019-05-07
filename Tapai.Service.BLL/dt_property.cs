/**  版本信息模板在安装目录下，可自行修改。
* dt_property.cs
*
* 功 能： N/A
* 类 名： dt_property
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/01/07 18:24:35   N/A    初版
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
using Tapai.Service.Model;
namespace Tapai.Service.BLL
{
    /// <summary>
    /// 用户组
    /// </summary>
    public partial class dt_property
    {
        private readonly Tapai.Service.DAL.dt_property dal = new Tapai.Service.DAL.dt_property();
        public dt_property()
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
        public bool Exists(string property_key, int id)
        {
            return dal.Exists(property_key, id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tapai.Service.Model.dt_property model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tapai.Service.Model.dt_property model)
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string property_key, int id)
        {

            return dal.Delete(property_key, id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            return dal.DeleteList(idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tapai.Service.Model.dt_property GetModel(int id)
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
        public List<Tapai.Service.Model.dt_property> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tapai.Service.Model.dt_property> DataTableToList(DataTable dt)
        {
            List<Tapai.Service.Model.dt_property> modelList = new List<Tapai.Service.Model.dt_property>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tapai.Service.Model.dt_property model;
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
        ///获取清零时间设置日期
        public DateTime GetUpdateTime(string key) => dal.GetUpdateTime(key);

        #endregion  ExtensionMethod
    }
}

