/**  版本信息模板在安装目录下，可自行修改。
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
using System.Text;
using System.Data.SqlClient;
using Tapai.Service.Common;

namespace Tapai.Service.DAL
{
    /// <summary>
    /// 数据访问类:tp_shop_operate
    /// </summary>
    public partial class tp_shop_operate
    {
        public tp_shop_operate()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("id", "tp_shop_operate");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tp_shop_operate");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tapai.Service.Model.tp_shop_operate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tp_shop_operate(");
            strSql.Append("user_id,nick_name,addtime,remark,type)");
            strSql.Append(" values (");
            strSql.Append("@user_id,@nick_name,@addtime,@remark,@type)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@user_id", SqlDbType.Int,4),
                    new SqlParameter("@nick_name", SqlDbType.NVarChar,50),
                    new SqlParameter("@addtime", SqlDbType.DateTime),
                    new SqlParameter("@remark", SqlDbType.NVarChar,500),
                    new SqlParameter("@type", SqlDbType.Int,4)};
            parameters[0].Value = model.user_id;
            parameters[1].Value = model.nick_name;
            parameters[2].Value = model.addtime;
            parameters[3].Value = model.remark;
            parameters[4].Value = model.type;

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
        public bool Update(Tapai.Service.Model.tp_shop_operate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tp_shop_operate set ");
            strSql.Append("user_id=@user_id,");
            strSql.Append("nick_name=@nick_name,");
            strSql.Append("addtime=@addtime,");
            strSql.Append("remark=@remark,");
            strSql.Append("type=@type");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@user_id", SqlDbType.Int,4),
                    new SqlParameter("@nick_name", SqlDbType.NVarChar,50),
                    new SqlParameter("@addtime", SqlDbType.DateTime),
                    new SqlParameter("@remark", SqlDbType.NVarChar,500),
                    new SqlParameter("@type", SqlDbType.Int,4),
                    new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.user_id;
            parameters[1].Value = model.nick_name;
            parameters[2].Value = model.addtime;
            parameters[3].Value = model.remark;
            parameters[4].Value = model.type;
            parameters[5].Value = model.id;

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
            strSql.Append("delete from tp_shop_operate ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
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
            strSql.Append("delete from tp_shop_operate ");
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
        public Tapai.Service.Model.tp_shop_operate GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,user_id,nick_name,addtime,remark,type from tp_shop_operate ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            Tapai.Service.Model.tp_shop_operate model = new Tapai.Service.Model.tp_shop_operate();
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
        public Tapai.Service.Model.tp_shop_operate DataRowToModel(DataRow row)
        {
            Tapai.Service.Model.tp_shop_operate model = new Tapai.Service.Model.tp_shop_operate();
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
                if (row["nick_name"] != null)
                {
                    model.nick_name = row["nick_name"].ToString();
                }
                if (row["addtime"] != null && row["addtime"].ToString() != "")
                {
                    model.addtime = DateTime.Parse(row["addtime"].ToString());
                }
                if (row["remark"] != null)
                {
                    model.remark = row["remark"].ToString();
                }
                if (row["type"] != null && row["type"].ToString() != "")
                {
                    model.type = int.Parse(row["type"].ToString());
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
            strSql.Append("select id,user_id,nick_name,addtime,remark,type ");
            strSql.Append(" FROM tp_shop_operate ");
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
            strSql.Append(" id,user_id,nick_name,addtime,remark,type ");
            strSql.Append(" FROM tp_shop_operate ");
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
            strSql.Append("select count(1) FROM tp_shop_operate ");
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
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex, out int total)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(0) from tp_shop_operate");
            if (!string.IsNullOrEmpty(strWhere))
            {
                strSql.AppendFormat(" where 1=1 {0}", strWhere);
            }
            total = Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString()));
            strSql.Clear();
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
            strSql.Append(")AS Row, T.*  from tp_shop_operate T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE 1=1 " + strWhere);
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
			parameters[0].Value = "tp_shop_operate";
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
        /// 取消商家的导购功能
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool UpdateDealer(int userId)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.AppendFormat("update dt_dealer_level set is_shop=0 where user_id={0}", userId);
            return DbHelperSQL.ExecuteSql(sqlBuilder.ToString()) > 0;
        }

        #endregion  ExtensionMethod
    }
}

