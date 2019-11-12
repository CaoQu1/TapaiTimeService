/**  版本信息模板在安装目录下，可自行修改。
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
using System.Text;
using System.Data.SqlClient;
using Tapai.Service.Common;
using System.Collections.Generic;

namespace Tapai.Service.DAL
{
    /// <summary>
    /// 数据访问类:tp_shop_brush
    /// </summary>
    public partial class tp_shop_brush
    {
        public tp_shop_brush()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("user_id", "tp_shop_brush");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int user_id, string code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tp_shop_brush");
            strSql.Append(" where user_id=@user_id and code=@code ");
            SqlParameter[] parameters = {
                    new SqlParameter("@user_id", SqlDbType.Int,4),
                    new SqlParameter("@code", SqlDbType.NVarChar,50)            };
            parameters[0].Value = user_id;
            parameters[1].Value = code;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Tapai.Service.Model.tp_shop_brush model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tp_shop_brush(");
            strSql.Append("user_id,nick_name,scan_year,scan_month,scan_day,status,code)");
            strSql.Append(" values (");
            strSql.Append("@user_id,@nick_name,@scan_year,@scan_month,@scan_day,@status,@code)");
            SqlParameter[] parameters = {
                    new SqlParameter("@user_id", SqlDbType.Int,4),
                    new SqlParameter("@nick_name", SqlDbType.NVarChar,10),
                    new SqlParameter("@scan_year", SqlDbType.VarChar,4),
                    new SqlParameter("@scan_month", SqlDbType.VarChar,2),
                    new SqlParameter("@scan_day", SqlDbType.VarChar,2),
                    new SqlParameter("@status", SqlDbType.Int,4),
                    new SqlParameter("@code", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.user_id;
            parameters[1].Value = model.nick_name;
            parameters[2].Value = model.scan_year;
            parameters[3].Value = model.scan_month;
            parameters[4].Value = model.scan_day;
            parameters[5].Value = model.status;
            parameters[6].Value = model.code;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(Tapai.Service.Model.tp_shop_brush model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tp_shop_brush set ");
            strSql.Append("nick_name=@nick_name,");
            strSql.Append("scan_year=@scan_year,");
            strSql.Append("scan_month=@scan_month,");
            strSql.Append("scan_day=@scan_day,");
            strSql.Append("status=@status");
            strSql.Append(" where user_id=@user_id and code=@code ");
            SqlParameter[] parameters = {
                    new SqlParameter("@nick_name", SqlDbType.NVarChar,10),
                    new SqlParameter("@scan_year", SqlDbType.VarChar,4),
                    new SqlParameter("@scan_month", SqlDbType.VarChar,2),
                    new SqlParameter("@scan_day", SqlDbType.VarChar,2),
                    new SqlParameter("@status", SqlDbType.Int,4),
                    new SqlParameter("@user_id", SqlDbType.Int,4),
                    new SqlParameter("@code", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.nick_name;
            parameters[1].Value = model.scan_year;
            parameters[2].Value = model.scan_month;
            parameters[3].Value = model.scan_day;
            parameters[4].Value = model.status;
            parameters[5].Value = model.user_id;
            parameters[6].Value = model.code;

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
        public bool Delete(int user_id, string code)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tp_shop_brush ");
            strSql.Append(" where user_id=@user_id and code=@code ");
            SqlParameter[] parameters = {
                    new SqlParameter("@user_id", SqlDbType.Int,4),
                    new SqlParameter("@code", SqlDbType.NVarChar,50)            };
            parameters[0].Value = user_id;
            parameters[1].Value = code;

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
        /// 得到一个对象实体
        /// </summary>
        public Tapai.Service.Model.tp_shop_brush GetModel(int user_id, string code)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 user_id,nick_name,scan_year,scan_month,scan_day,status,code from tp_shop_brush ");
            strSql.Append(" where user_id=@user_id and code=@code ");
            SqlParameter[] parameters = {
                    new SqlParameter("@user_id", SqlDbType.Int,4),
                    new SqlParameter("@code", SqlDbType.NVarChar,50)            };
            parameters[0].Value = user_id;
            parameters[1].Value = code;

            Tapai.Service.Model.tp_shop_brush model = new Tapai.Service.Model.tp_shop_brush();
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
        public Tapai.Service.Model.tp_shop_brush DataRowToModel(DataRow row)
        {
            Tapai.Service.Model.tp_shop_brush model = new Tapai.Service.Model.tp_shop_brush();
            if (row != null)
            {
                if (row["user_id"] != null && row["user_id"].ToString() != "")
                {
                    model.user_id = int.Parse(row["user_id"].ToString());
                }
                if (row["nick_name"] != null)
                {
                    model.nick_name = row["nick_name"].ToString();
                }
                if (row["scan_year"] != null)
                {
                    model.scan_year = row["scan_year"].ToString();
                }
                if (row["scan_month"] != null)
                {
                    model.scan_month = row["scan_month"].ToString();
                }
                if (row["scan_day"] != null)
                {
                    model.scan_day = row["scan_day"].ToString();
                }
                if (row["status"] != null && row["status"].ToString() != "")
                {
                    model.status = (EnumShopRecordStatus)int.Parse(row["status"].ToString());
                }
                if (row["code"] != null)
                {
                    model.code = row["code"].ToString();
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
            strSql.Append("select user_id,nick_name,scan_year,scan_month,scan_day,status,code ");
            strSql.Append(" FROM tp_shop_brush ");
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
            strSql.Append(" user_id,nick_name,scan_year,scan_month,scan_day,status,code ");
            strSql.Append(" FROM tp_shop_brush ");
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
            strSql.Append("select count(1) FROM tp_shop_brush ");
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
                strSql.Append("order by T.code desc");
            }
            strSql.Append(")AS Row, T.*  from tp_shop_brush T ");
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
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "tp_shop_brush";
			parameters[1].Value = "code";
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
        /// 获取当月导购商家异常地址统计
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public DataTable GetCurrentMonthStatistics(string year, string month)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.AppendFormat(@"select a.number,a.user_id,u.user_name,u.nick_name from(select user_id,COUNT(*) as number from tp_shop_brush where scan_year='{0}' and scan_month='{1}'  and status=2 group by user_id) as a
left join dt_users as u
on u.id = a.user_id
", year, month);
            var dataSet = DbHelperSQL.Query(sqlBuilder.ToString());
            return dataSet != null && dataSet.Tables.Count > 0 ? dataSet.Tables[0] : null;
        }
        #endregion  ExtensionMethod
    }
}

