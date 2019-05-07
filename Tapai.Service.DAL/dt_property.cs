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
using System.Text;
using System.Data.SqlClient;
using Porter.Corporation.DBUtility;
using Tapai.Service.Common;

namespace Tapai.Service.DAL
{
    /// <summary>
    /// 数据访问类:dt_property
    /// </summary>
    public partial class dt_property
    {
        public dt_property()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("id", "dt_property");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string property_key, int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from dt_property");
            strSql.Append(" where property_key=SQL2012property_key and id=SQL2012id ");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012property_key", SqlDbType.NVarChar,250),
                    new SqlParameter("SQL2012id", SqlDbType.Int,4)          };
            parameters[0].Value = property_key;
            parameters[1].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tapai.Service.Model.dt_property model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into dt_property(");
            strSql.Append("property_key,property_value,name,description,tags,admin_name,admin_id,admin_real_name,add_time,update_time)");
            strSql.Append(" values (");
            strSql.Append("SQL2012property_key,SQL2012property_value,SQL2012name,SQL2012description,SQL2012tags,SQL2012admin_name,SQL2012admin_id,SQL2012admin_real_name,SQL2012add_time,SQL2012update_time)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012property_key", SqlDbType.NVarChar,250),
                    new SqlParameter("SQL2012property_value", SqlDbType.NVarChar,-1),
                    new SqlParameter("SQL2012name", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012description", SqlDbType.NVarChar,-1),
                    new SqlParameter("SQL2012tags", SqlDbType.NVarChar,250),
                    new SqlParameter("SQL2012admin_name", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012admin_id", SqlDbType.Int,4),
                    new SqlParameter("SQL2012admin_real_name", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012add_time", SqlDbType.DateTime),
                    new SqlParameter("SQL2012update_time", SqlDbType.DateTime)};
            parameters[0].Value = model.property_key;
            parameters[1].Value = model.property_value;
            parameters[2].Value = model.name;
            parameters[3].Value = model.description;
            parameters[4].Value = model.tags;
            parameters[5].Value = model.admin_name;
            parameters[6].Value = model.admin_id;
            parameters[7].Value = model.admin_real_name;
            parameters[8].Value = model.add_time;
            parameters[9].Value = model.update_time;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tapai.Service.Model.dt_property model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update dt_property set ");
            strSql.Append("property_value=SQL2012property_value,");
            strSql.Append("name=SQL2012name,");
            strSql.Append("description=SQL2012description,");
            strSql.Append("tags=SQL2012tags,");
            strSql.Append("admin_name=SQL2012admin_name,");
            strSql.Append("admin_id=SQL2012admin_id,");
            strSql.Append("admin_real_name=SQL2012admin_real_name,");
            strSql.Append("add_time=SQL2012add_time,");
            strSql.Append("update_time=SQL2012update_time");
            strSql.Append(" where id=SQL2012id");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012property_value", SqlDbType.NVarChar,-1),
                    new SqlParameter("SQL2012name", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012description", SqlDbType.NVarChar,-1),
                    new SqlParameter("SQL2012tags", SqlDbType.NVarChar,250),
                    new SqlParameter("SQL2012admin_name", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012admin_id", SqlDbType.Int,4),
                    new SqlParameter("SQL2012admin_real_name", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012add_time", SqlDbType.DateTime),
                    new SqlParameter("SQL2012update_time", SqlDbType.DateTime),
                    new SqlParameter("SQL2012id", SqlDbType.Int,4),
                    new SqlParameter("SQL2012property_key", SqlDbType.NVarChar,250)};
            parameters[0].Value = model.property_value;
            parameters[1].Value = model.name;
            parameters[2].Value = model.description;
            parameters[3].Value = model.tags;
            parameters[4].Value = model.admin_name;
            parameters[5].Value = model.admin_id;
            parameters[6].Value = model.admin_real_name;
            parameters[7].Value = model.add_time;
            parameters[8].Value = model.update_time;
            parameters[9].Value = model.id;
            parameters[10].Value = model.property_key;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from dt_property ");
            strSql.Append(" where id=SQL2012id");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string property_key, int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from dt_property ");
            strSql.Append(" where property_key=SQL2012property_key and id=SQL2012id ");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012property_key", SqlDbType.NVarChar,250),
                    new SqlParameter("SQL2012id", SqlDbType.Int,4)          };
            parameters[0].Value = property_key;
            parameters[1].Value = id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from dt_property ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tapai.Service.Model.dt_property GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,property_key,property_value,name,description,tags,admin_name,admin_id,admin_real_name,add_time,update_time from dt_property ");
            strSql.Append(" where id=SQL2012id");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            Tapai.Service.Model.dt_property model = new Tapai.Service.Model.dt_property();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tapai.Service.Model.dt_property DataRowToModel(DataRow row)
        {
            Tapai.Service.Model.dt_property model = new Tapai.Service.Model.dt_property();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["property_key"] != null)
                {
                    model.property_key = row["property_key"].ToString();
                }
                if (row["property_value"] != null)
                {
                    model.property_value = row["property_value"].ToString();
                }
                if (row["name"] != null)
                {
                    model.name = row["name"].ToString();
                }
                if (row["description"] != null)
                {
                    model.description = row["description"].ToString();
                }
                if (row["tags"] != null)
                {
                    model.tags = row["tags"].ToString();
                }
                if (row["admin_name"] != null)
                {
                    model.admin_name = row["admin_name"].ToString();
                }
                if (row["admin_id"] != null && row["admin_id"].ToString() != "")
                {
                    model.admin_id = int.Parse(row["admin_id"].ToString());
                }
                if (row["admin_real_name"] != null)
                {
                    model.admin_real_name = row["admin_real_name"].ToString();
                }
                if (row["add_time"] != null && row["add_time"].ToString() != "")
                {
                    model.add_time = DateTime.Parse(row["add_time"].ToString());
                }
                if (row["update_time"] != null && row["update_time"].ToString() != "")
                {
                    model.update_time = DateTime.Parse(row["update_time"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,property_key,property_value,name,description,tags,admin_name,admin_id,admin_real_name,add_time,update_time ");
            strSql.Append(" FROM dt_property ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" id,property_key,property_value,name,description,tags,admin_name,admin_id,admin_real_name,add_time,update_time ");
            strSql.Append(" FROM dt_property ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM dt_property ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from dt_property T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012tblName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012fldName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012PageSize", SqlDbType.Int),
					new SqlParameter("SQL2012PageIndex", SqlDbType.Int),
					new SqlParameter("SQL2012IsReCount", SqlDbType.Bit),
					new SqlParameter("SQL2012OrderType", SqlDbType.Bit),
					new SqlParameter("SQL2012strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "dt_property";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 获取更新时间
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public DateTime GetUpdateTime(string key)
        {
            try
            {
                StringBuilder strSql = new StringBuilder("select");
                if (string.IsNullOrEmpty(key))
                {
                    strSql.Append(" update_time ");
                    key = PubConst.INTEGRALCLEARTIME;
                }
                else
                {
                    strSql.Append(" property_value ");
                }
                strSql.Append(" from dt_property ");
                strSql.Append(" where property_key =@property_key");
                SqlParameter[] parameters = {
                    new SqlParameter("@property_key", SqlDbType.VarChar,250)
            };
                parameters[0].Value = key;
                var obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
                return obj != null && DateTime.TryParse(obj.ToString(), out DateTime update_time) ? update_time : DateTime.Now;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion  ExtensionMethod
    }
}

