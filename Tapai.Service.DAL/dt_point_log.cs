/**  版本信息模板在安装目录下，可自行修改。
* dt_point_log.cs
*
* 功 能： N/A
* 类 名： dt_point_log
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/01/07 18:24:33   N/A    初版
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
    /// 数据访问类:dt_point_log
    /// </summary>
    public partial class dt_point_log
    {
        public dt_point_log()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("id", "dt_point_log");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from dt_point_log");
            strSql.Append(" where id=SQL2012id");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tapai.Service.Model.dt_point_log model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into dt_point_log(");
            strSql.Append("user_id,user_name,value,remark,add_time,rest_value,state,area_attr,type,code,scan_location,latitude,longitude,scan_ip,scan_ip_address)");
            strSql.Append(" values (");
            strSql.Append("SQL2012user_id,SQL2012user_name,SQL2012value,SQL2012remark,SQL2012add_time,SQL2012rest_value,SQL2012state,SQL2012area_attr,SQL2012type,SQL2012code,SQL2012scan_location,SQL2012latitude,SQL2012longitude,SQL2012scan_ip,SQL2012scan_ip_address)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012user_id", SqlDbType.Int,4),
                    new SqlParameter("SQL2012user_name", SqlDbType.NVarChar,100),
                    new SqlParameter("SQL2012value", SqlDbType.Int,4),
                    new SqlParameter("SQL2012remark", SqlDbType.NVarChar,500),
                    new SqlParameter("SQL2012add_time", SqlDbType.DateTime),
                    new SqlParameter("SQL2012rest_value", SqlDbType.Int,4),
                    new SqlParameter("SQL2012state", SqlDbType.Int,4),
                    new SqlParameter("SQL2012area_attr", SqlDbType.Int,4),
                    new SqlParameter("SQL2012type", SqlDbType.Int,4),
                    new SqlParameter("SQL2012code", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012scan_location", SqlDbType.NVarChar,500),
                    new SqlParameter("SQL2012latitude", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012longitude", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012scan_ip", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012scan_ip_address", SqlDbType.NVarChar,500)};
            parameters[0].Value = model.user_id;
            parameters[1].Value = model.user_name;
            parameters[2].Value = model.value;
            parameters[3].Value = model.remark;
            parameters[4].Value = model.add_time;
            parameters[5].Value = model.rest_value;
            parameters[6].Value = model.state;
            parameters[7].Value = model.area_attr;
            parameters[8].Value = model.type;
            parameters[9].Value = model.code;
            parameters[10].Value = model.scan_location;
            parameters[11].Value = model.latitude;
            parameters[12].Value = model.longitude;
            parameters[13].Value = model.scan_ip;
            parameters[14].Value = model.scan_ip_address;

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
        public bool Update(Tapai.Service.Model.dt_point_log model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update dt_point_log set ");
            strSql.Append("user_id=SQL2012user_id,");
            strSql.Append("user_name=SQL2012user_name,");
            strSql.Append("value=SQL2012value,");
            strSql.Append("remark=SQL2012remark,");
            strSql.Append("add_time=SQL2012add_time,");
            strSql.Append("rest_value=SQL2012rest_value,");
            strSql.Append("state=SQL2012state,");
            strSql.Append("area_attr=SQL2012area_attr,");
            strSql.Append("type=SQL2012type,");
            strSql.Append("code=SQL2012code,");
            strSql.Append("scan_location=SQL2012scan_location,");
            strSql.Append("latitude=SQL2012latitude,");
            strSql.Append("longitude=SQL2012longitude,");
            strSql.Append("scan_ip=SQL2012scan_ip,");
            strSql.Append("scan_ip_address=SQL2012scan_ip_address");
            strSql.Append(" where id=SQL2012id");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012user_id", SqlDbType.Int,4),
                    new SqlParameter("SQL2012user_name", SqlDbType.NVarChar,100),
                    new SqlParameter("SQL2012value", SqlDbType.Int,4),
                    new SqlParameter("SQL2012remark", SqlDbType.NVarChar,500),
                    new SqlParameter("SQL2012add_time", SqlDbType.DateTime),
                    new SqlParameter("SQL2012rest_value", SqlDbType.Int,4),
                    new SqlParameter("SQL2012state", SqlDbType.Int,4),
                    new SqlParameter("SQL2012area_attr", SqlDbType.Int,4),
                    new SqlParameter("SQL2012type", SqlDbType.Int,4),
                    new SqlParameter("SQL2012code", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012scan_location", SqlDbType.NVarChar,500),
                    new SqlParameter("SQL2012latitude", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012longitude", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012scan_ip", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012scan_ip_address", SqlDbType.NVarChar,500),
                    new SqlParameter("SQL2012id", SqlDbType.Int,4)};
            parameters[0].Value = model.user_id;
            parameters[1].Value = model.user_name;
            parameters[2].Value = model.value;
            parameters[3].Value = model.remark;
            parameters[4].Value = model.add_time;
            parameters[5].Value = model.rest_value;
            parameters[6].Value = model.state;
            parameters[7].Value = model.area_attr;
            parameters[8].Value = model.type;
            parameters[9].Value = model.code;
            parameters[10].Value = model.scan_location;
            parameters[11].Value = model.latitude;
            parameters[12].Value = model.longitude;
            parameters[13].Value = model.scan_ip;
            parameters[14].Value = model.scan_ip_address;
            parameters[15].Value = model.id;

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
            strSql.Append("delete from dt_point_log ");
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from dt_point_log ");
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
        public Tapai.Service.Model.dt_point_log GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,user_id,user_name,value,remark,add_time,rest_value,state,area_attr,type,code,scan_location,latitude,longitude,scan_ip,scan_ip_address from dt_point_log ");
            strSql.Append(" where id=SQL2012id");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            Tapai.Service.Model.dt_point_log model = new Tapai.Service.Model.dt_point_log();
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
        public Tapai.Service.Model.dt_point_log DataRowToModel(DataRow row)
        {
            Tapai.Service.Model.dt_point_log model = new Tapai.Service.Model.dt_point_log();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["user_id"] != null && row["user_id"].ToString() != "")
                {
                    model.user_id = int.Parse(row["user_id"].ToString());
                }
                if (row["user_name"] != null)
                {
                    model.user_name = row["user_name"].ToString();
                }
                if (row["value"] != null && row["value"].ToString() != "")
                {
                    model.value = int.Parse(row["value"].ToString());
                }
                if (row["remark"] != null)
                {
                    model.remark = row["remark"].ToString();
                }
                if (row["add_time"] != null && row["add_time"].ToString() != "")
                {
                    model.add_time = DateTime.Parse(row["add_time"].ToString());
                }
                if (row["rest_value"] != null && row["rest_value"].ToString() != "")
                {
                    model.rest_value = int.Parse(row["rest_value"].ToString());
                }
                if (row["state"] != null && row["state"].ToString() != "")
                {
                    model.state = int.Parse(row["state"].ToString());
                }
                if (row["area_attr"] != null && row["area_attr"].ToString() != "")
                {
                    model.area_attr = int.Parse(row["area_attr"].ToString());
                }
                if (row["type"] != null && row["type"].ToString() != "")
                {
                    model.type = int.Parse(row["type"].ToString());
                }
                if (row["code"] != null)
                {
                    model.code = row["code"].ToString();
                }
                if (row["scan_location"] != null)
                {
                    model.scan_location = row["scan_location"].ToString();
                }
                if (row["latitude"] != null)
                {
                    model.latitude = row["latitude"].ToString();
                }
                if (row["longitude"] != null)
                {
                    model.longitude = row["longitude"].ToString();
                }
                if (row["scan_ip"] != null)
                {
                    model.scan_ip = row["scan_ip"].ToString();
                }
                if (row["scan_ip_address"] != null)
                {
                    model.scan_ip_address = row["scan_ip_address"].ToString();
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
            strSql.Append("select id,user_id,user_name,value,remark,add_time,rest_value,state,area_attr,type,code,scan_location,latitude,longitude,scan_ip,scan_ip_address ");
            strSql.Append(" FROM dt_point_log ");
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
            strSql.Append(" id,user_id,user_name,value,remark,add_time,rest_value,state,area_attr,type,code,scan_location,latitude,longitude,scan_ip,scan_ip_address ");
            strSql.Append(" FROM dt_point_log ");
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
            strSql.Append("select count(1) FROM dt_point_log ");
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
            strSql.Append(")AS Row, T.*  from dt_point_log T ");
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
			parameters[0].Value = "dt_point_log";
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
        /// 获取清零时间节点以前积分未使用的用户总数
        /// </summary>
        /// <returns></returns>
        public int GetNotUsePointCount()
        {
            var obj = DbHelperSQL.RunProcedure("not_user_point_count", new SqlParameter[] { new SqlParameter("@property_key", PubConst.INTEGRALCLEARTIMENODE) }, "total");
            return obj != null && obj.Tables.Count > 0 && obj.Tables[0].Rows.Count > 0 ? Convert.ToInt32(obj.Tables[0].Rows[0][0]) : 0;
        }

        /// <summary>
        /// 获取清零时间节点以前积分未使用
        /// </summary>
        /// <returns></returns>
        public DataTable GetNotUserPoint(int pageIndex, int pageSize)
        {
            var sqlParameters = new SqlParameter[] {
                 new SqlParameter("@property_key", PubConst.INTEGRALCLEARTIMENODE),
                 new SqlParameter("@start",SqlDbType.Int,4){ Value=pageIndex*pageSize+1},
                 new SqlParameter("@end",SqlDbType.Int,4){ Value=(pageIndex+1)*pageSize}
            };
            var dataSet = DbHelperSQL.RunProcedure("not_user_point", sqlParameters, "userPoint");
            return dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0 ? dataSet.Tables[0] : null;
        }

        /// <summary>
        /// 积分清零
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        public bool UpdateUserPoint(Model.dt_point_log log)
        {
            var sqlParameters = new SqlParameter[] {
              new SqlParameter("@property_key", PubConst.INTEGRALCLEARTIMENODE),
              new SqlParameter("@user_id",SqlDbType.Int,4){ Value=log.user_id},
              new SqlParameter("@user_name",SqlDbType.NVarChar,100){ Value=log.user_name},
              new SqlParameter("@value",SqlDbType.Int,4){ Value=log.value},
              new SqlParameter("@remark",SqlDbType.NVarChar,500){ Value=log.remark},
              new SqlParameter("@add_time",SqlDbType.DateTime){ Value=log.add_time},
              new SqlParameter("@rest_value",SqlDbType.Int,4){Value=log.rest_value},
              new SqlParameter("@state",SqlDbType.Int,4){ Value=log.state},
              new SqlParameter("@area_attr",SqlDbType.NVarChar,100){ Value=log.area_attr},
              new SqlParameter("@type",SqlDbType.NVarChar,100){ Value=log.type},
            };

            DbHelperSQL.RunProcedure("intergval_clear", sqlParameters, out int returnValue);
            return returnValue > 0;
        }
        #endregion  ExtensionMethod
    }
}

