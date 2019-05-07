/**  版本信息模板在安装目录下，可自行修改。
* dt_user_groups.cs
*
* 功 能： N/A
* 类 名： dt_user_groups
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

namespace Tapai.Service.DAL
{
    /// <summary>
    /// 数据访问类:dt_user_groups
    /// </summary>
    public partial class dt_user_groups
    {
        public dt_user_groups()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("id", "dt_user_groups");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from dt_user_groups");
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
        public int Add(Tapai.Service.Model.dt_user_groups model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into dt_user_groups(");
            strSql.Append("title,grade,upgrade_exp,amount,point,discount,is_default,is_upgrade,is_lock)");
            strSql.Append(" values (");
            strSql.Append("SQL2012title,SQL2012grade,SQL2012upgrade_exp,SQL2012amount,SQL2012point,SQL2012discount,SQL2012is_default,SQL2012is_upgrade,SQL2012is_lock)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012title", SqlDbType.NVarChar,100),
                    new SqlParameter("SQL2012grade", SqlDbType.Int,4),
                    new SqlParameter("SQL2012upgrade_exp", SqlDbType.Int,4),
                    new SqlParameter("SQL2012amount", SqlDbType.Decimal,5),
                    new SqlParameter("SQL2012point", SqlDbType.Int,4),
                    new SqlParameter("SQL2012discount", SqlDbType.Int,4),
                    new SqlParameter("SQL2012is_default", SqlDbType.TinyInt,1),
                    new SqlParameter("SQL2012is_upgrade", SqlDbType.TinyInt,1),
                    new SqlParameter("SQL2012is_lock", SqlDbType.TinyInt,1)};
            parameters[0].Value = model.title;
            parameters[1].Value = model.grade;
            parameters[2].Value = model.upgrade_exp;
            parameters[3].Value = model.amount;
            parameters[4].Value = model.point;
            parameters[5].Value = model.discount;
            parameters[6].Value = model.is_default;
            parameters[7].Value = model.is_upgrade;
            parameters[8].Value = model.is_lock;

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
        public bool Update(Tapai.Service.Model.dt_user_groups model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update dt_user_groups set ");
            strSql.Append("title=SQL2012title,");
            strSql.Append("grade=SQL2012grade,");
            strSql.Append("upgrade_exp=SQL2012upgrade_exp,");
            strSql.Append("amount=SQL2012amount,");
            strSql.Append("point=SQL2012point,");
            strSql.Append("discount=SQL2012discount,");
            strSql.Append("is_default=SQL2012is_default,");
            strSql.Append("is_upgrade=SQL2012is_upgrade,");
            strSql.Append("is_lock=SQL2012is_lock");
            strSql.Append(" where id=SQL2012id");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012title", SqlDbType.NVarChar,100),
                    new SqlParameter("SQL2012grade", SqlDbType.Int,4),
                    new SqlParameter("SQL2012upgrade_exp", SqlDbType.Int,4),
                    new SqlParameter("SQL2012amount", SqlDbType.Decimal,5),
                    new SqlParameter("SQL2012point", SqlDbType.Int,4),
                    new SqlParameter("SQL2012discount", SqlDbType.Int,4),
                    new SqlParameter("SQL2012is_default", SqlDbType.TinyInt,1),
                    new SqlParameter("SQL2012is_upgrade", SqlDbType.TinyInt,1),
                    new SqlParameter("SQL2012is_lock", SqlDbType.TinyInt,1),
                    new SqlParameter("SQL2012id", SqlDbType.Int,4)};
            parameters[0].Value = model.title;
            parameters[1].Value = model.grade;
            parameters[2].Value = model.upgrade_exp;
            parameters[3].Value = model.amount;
            parameters[4].Value = model.point;
            parameters[5].Value = model.discount;
            parameters[6].Value = model.is_default;
            parameters[7].Value = model.is_upgrade;
            parameters[8].Value = model.is_lock;
            parameters[9].Value = model.id;

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
            strSql.Append("delete from dt_user_groups ");
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
            strSql.Append("delete from dt_user_groups ");
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
        public Tapai.Service.Model.dt_user_groups GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,title,grade,upgrade_exp,amount,point,discount,is_default,is_upgrade,is_lock from dt_user_groups ");
            strSql.Append(" where id=SQL2012id");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            Tapai.Service.Model.dt_user_groups model = new Tapai.Service.Model.dt_user_groups();
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
        public Tapai.Service.Model.dt_user_groups DataRowToModel(DataRow row)
        {
            Tapai.Service.Model.dt_user_groups model = new Tapai.Service.Model.dt_user_groups();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["title"] != null)
                {
                    model.title = row["title"].ToString();
                }
                if (row["grade"] != null && row["grade"].ToString() != "")
                {
                    model.grade = int.Parse(row["grade"].ToString());
                }
                if (row["upgrade_exp"] != null && row["upgrade_exp"].ToString() != "")
                {
                    model.upgrade_exp = int.Parse(row["upgrade_exp"].ToString());
                }
                if (row["amount"] != null && row["amount"].ToString() != "")
                {
                    model.amount = decimal.Parse(row["amount"].ToString());
                }
                if (row["point"] != null && row["point"].ToString() != "")
                {
                    model.point = int.Parse(row["point"].ToString());
                }
                if (row["discount"] != null && row["discount"].ToString() != "")
                {
                    model.discount = int.Parse(row["discount"].ToString());
                }
                if (row["is_default"] != null && row["is_default"].ToString() != "")
                {
                    model.is_default = int.Parse(row["is_default"].ToString());
                }
                if (row["is_upgrade"] != null && row["is_upgrade"].ToString() != "")
                {
                    model.is_upgrade = int.Parse(row["is_upgrade"].ToString());
                }
                if (row["is_lock"] != null && row["is_lock"].ToString() != "")
                {
                    model.is_lock = int.Parse(row["is_lock"].ToString());
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
            strSql.Append("select id,title,grade,upgrade_exp,amount,point,discount,is_default,is_upgrade,is_lock ");
            strSql.Append(" FROM dt_user_groups ");
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
            strSql.Append(" id,title,grade,upgrade_exp,amount,point,discount,is_default,is_upgrade,is_lock ");
            strSql.Append(" FROM dt_user_groups ");
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
            strSql.Append("select count(1) FROM dt_user_groups ");
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
            strSql.Append(")AS Row, T.*  from dt_user_groups T ");
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
			parameters[0].Value = "dt_user_groups";
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

        #endregion  ExtensionMethod
    }
}

