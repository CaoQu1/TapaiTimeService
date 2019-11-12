/**  版本信息模板在安装目录下，可自行修改。
* dt_users.cs
*
* 功 能： N/A
* 类 名： dt_users
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/01/07 18:24:34   N/A    初版
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
    /// 数据访问类:dt_users
    /// </summary>
    public partial class dt_users
    {
        public dt_users()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("id", "dt_users");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from dt_users");
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
        public int Add(Tapai.Service.Model.dt_users model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into dt_users(");
            strSql.Append("group_id,user_name,password,email,nick_name,avatar,sex,birthday,telphone,mobile,qq,area,address,safe_question,safe_answer,amount,point,exp,is_lock,reg_time,reg_ip,weak,referee_mobile,area_id,isgive_points,reg_address,is_group,w_update_time,is_test)");
            strSql.Append(" values (");
            strSql.Append("SQL2012group_id,SQL2012user_name,SQL2012password,SQL2012email,SQL2012nick_name,SQL2012avatar,SQL2012sex,SQL2012birthday,SQL2012telphone,SQL2012mobile,SQL2012qq,SQL2012area,SQL2012address,SQL2012safe_question,SQL2012safe_answer,SQL2012amount,SQL2012point,SQL2012exp,SQL2012is_lock,SQL2012reg_time,SQL2012reg_ip,SQL2012weak,SQL2012referee_mobile,SQL2012area_id,SQL2012isgive_points,SQL2012reg_address,SQL2012is_group,SQL2012w_update_time,SQL2012is_test)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012group_id", SqlDbType.Int,4),
                    new SqlParameter("SQL2012user_name", SqlDbType.NVarChar,100),
                    new SqlParameter("SQL2012password", SqlDbType.NVarChar,100),
                    new SqlParameter("SQL2012email", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012nick_name", SqlDbType.NVarChar,100),
                    new SqlParameter("SQL2012avatar", SqlDbType.NVarChar,255),
                    new SqlParameter("SQL2012sex", SqlDbType.NVarChar,20),
                    new SqlParameter("SQL2012birthday", SqlDbType.DateTime),
                    new SqlParameter("SQL2012telphone", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012mobile", SqlDbType.NVarChar,20),
                    new SqlParameter("SQL2012qq", SqlDbType.NVarChar,30),
                    new SqlParameter("SQL2012area", SqlDbType.NVarChar,255),
                    new SqlParameter("SQL2012address", SqlDbType.NVarChar,255),
                    new SqlParameter("SQL2012safe_question", SqlDbType.NVarChar,255),
                    new SqlParameter("SQL2012safe_answer", SqlDbType.NVarChar,255),
                    new SqlParameter("SQL2012amount", SqlDbType.Decimal,5),
                    new SqlParameter("SQL2012point", SqlDbType.Int,4),
                    new SqlParameter("SQL2012exp", SqlDbType.Int,4),
                    new SqlParameter("SQL2012is_lock", SqlDbType.TinyInt,1),
                    new SqlParameter("SQL2012reg_time", SqlDbType.DateTime),
                    new SqlParameter("SQL2012reg_ip", SqlDbType.NVarChar,30),
                    new SqlParameter("SQL2012weak", SqlDbType.Int,4),
                    new SqlParameter("SQL2012referee_mobile", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012area_id", SqlDbType.Int,4),
                    new SqlParameter("SQL2012isgive_points", SqlDbType.Bit,1),
                    new SqlParameter("SQL2012reg_address", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012is_group", SqlDbType.Bit,1),
                    new SqlParameter("SQL2012w_update_time", SqlDbType.DateTime),
                    new SqlParameter("SQL2012is_test", SqlDbType.Bit,1)};
            parameters[0].Value = model.group_id;
            parameters[1].Value = model.user_name;
            parameters[2].Value = model.password;
            parameters[3].Value = model.email;
            parameters[4].Value = model.nick_name;
            parameters[5].Value = model.avatar;
            parameters[6].Value = model.sex;
            parameters[7].Value = model.birthday;
            parameters[8].Value = model.telphone;
            parameters[9].Value = model.mobile;
            parameters[10].Value = model.qq;
            parameters[11].Value = model.area;
            parameters[12].Value = model.address;
            parameters[13].Value = model.safe_question;
            parameters[14].Value = model.safe_answer;
            parameters[15].Value = model.amount;
            parameters[16].Value = model.point;
            parameters[17].Value = model.exp;
            parameters[18].Value = model.is_lock;
            parameters[19].Value = model.reg_time;
            parameters[20].Value = model.reg_ip;
            parameters[21].Value = model.weak;
            parameters[22].Value = model.referee_mobile;
            parameters[23].Value = model.area_id;
            parameters[24].Value = model.isgive_points;
            parameters[25].Value = model.reg_address;
            parameters[26].Value = model.is_group;
            parameters[27].Value = model.w_update_time;
            parameters[28].Value = model.is_test;

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
        public bool Update(Tapai.Service.Model.dt_users model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update dt_users set ");
            strSql.Append("group_id=SQL2012group_id,");
            strSql.Append("user_name=SQL2012user_name,");
            strSql.Append("password=SQL2012password,");
            strSql.Append("email=SQL2012email,");
            strSql.Append("nick_name=SQL2012nick_name,");
            strSql.Append("avatar=SQL2012avatar,");
            strSql.Append("sex=SQL2012sex,");
            strSql.Append("birthday=SQL2012birthday,");
            strSql.Append("telphone=SQL2012telphone,");
            strSql.Append("mobile=SQL2012mobile,");
            strSql.Append("qq=SQL2012qq,");
            strSql.Append("area=SQL2012area,");
            strSql.Append("address=SQL2012address,");
            strSql.Append("safe_question=SQL2012safe_question,");
            strSql.Append("safe_answer=SQL2012safe_answer,");
            strSql.Append("amount=SQL2012amount,");
            strSql.Append("point=SQL2012point,");
            strSql.Append("exp=SQL2012exp,");
            strSql.Append("is_lock=SQL2012is_lock,");
            strSql.Append("reg_time=SQL2012reg_time,");
            strSql.Append("reg_ip=SQL2012reg_ip,");
            strSql.Append("weak=SQL2012weak,");
            strSql.Append("referee_mobile=SQL2012referee_mobile,");
            strSql.Append("area_id=SQL2012area_id,");
            strSql.Append("isgive_points=SQL2012isgive_points,");
            strSql.Append("reg_address=SQL2012reg_address,");
            strSql.Append("is_group=SQL2012is_group,");
            strSql.Append("w_update_time=SQL2012w_update_time,");
            strSql.Append("is_test=SQL2012is_test");
            strSql.Append(" where id=SQL2012id");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012group_id", SqlDbType.Int,4),
                    new SqlParameter("SQL2012user_name", SqlDbType.NVarChar,100),
                    new SqlParameter("SQL2012password", SqlDbType.NVarChar,100),
                    new SqlParameter("SQL2012email", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012nick_name", SqlDbType.NVarChar,100),
                    new SqlParameter("SQL2012avatar", SqlDbType.NVarChar,255),
                    new SqlParameter("SQL2012sex", SqlDbType.NVarChar,20),
                    new SqlParameter("SQL2012birthday", SqlDbType.DateTime),
                    new SqlParameter("SQL2012telphone", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012mobile", SqlDbType.NVarChar,20),
                    new SqlParameter("SQL2012qq", SqlDbType.NVarChar,30),
                    new SqlParameter("SQL2012area", SqlDbType.NVarChar,255),
                    new SqlParameter("SQL2012address", SqlDbType.NVarChar,255),
                    new SqlParameter("SQL2012safe_question", SqlDbType.NVarChar,255),
                    new SqlParameter("SQL2012safe_answer", SqlDbType.NVarChar,255),
                    new SqlParameter("SQL2012amount", SqlDbType.Decimal,5),
                    new SqlParameter("SQL2012point", SqlDbType.Int,4),
                    new SqlParameter("SQL2012exp", SqlDbType.Int,4),
                    new SqlParameter("SQL2012is_lock", SqlDbType.TinyInt,1),
                    new SqlParameter("SQL2012reg_time", SqlDbType.DateTime),
                    new SqlParameter("SQL2012reg_ip", SqlDbType.NVarChar,30),
                    new SqlParameter("SQL2012weak", SqlDbType.Int,4),
                    new SqlParameter("SQL2012referee_mobile", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012area_id", SqlDbType.Int,4),
                    new SqlParameter("SQL2012isgive_points", SqlDbType.Bit,1),
                    new SqlParameter("SQL2012reg_address", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012is_group", SqlDbType.Bit,1),
                    new SqlParameter("SQL2012w_update_time", SqlDbType.DateTime),
                    new SqlParameter("SQL2012is_test", SqlDbType.Bit,1),
                    new SqlParameter("SQL2012id", SqlDbType.Int,4)};
            parameters[0].Value = model.group_id;
            parameters[1].Value = model.user_name;
            parameters[2].Value = model.password;
            parameters[3].Value = model.email;
            parameters[4].Value = model.nick_name;
            parameters[5].Value = model.avatar;
            parameters[6].Value = model.sex;
            parameters[7].Value = model.birthday;
            parameters[8].Value = model.telphone;
            parameters[9].Value = model.mobile;
            parameters[10].Value = model.qq;
            parameters[11].Value = model.area;
            parameters[12].Value = model.address;
            parameters[13].Value = model.safe_question;
            parameters[14].Value = model.safe_answer;
            parameters[15].Value = model.amount;
            parameters[16].Value = model.point;
            parameters[17].Value = model.exp;
            parameters[18].Value = model.is_lock;
            parameters[19].Value = model.reg_time;
            parameters[20].Value = model.reg_ip;
            parameters[21].Value = model.weak;
            parameters[22].Value = model.referee_mobile;
            parameters[23].Value = model.area_id;
            parameters[24].Value = model.isgive_points;
            parameters[25].Value = model.reg_address;
            parameters[26].Value = model.is_group;
            parameters[27].Value = model.w_update_time;
            parameters[28].Value = model.is_test;
            parameters[29].Value = model.id;

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
            strSql.Append("delete from dt_users ");
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
            strSql.Append("delete from dt_users ");
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
        public Tapai.Service.Model.dt_users GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,group_id,user_name,password,email,nick_name,avatar,sex,birthday,telphone,mobile,qq,area,address,safe_question,safe_answer,amount,point,exp,is_lock,reg_time,reg_ip,weak,referee_mobile,area_id,isgive_points,reg_address,is_group,w_update_time,is_test from dt_users ");
            strSql.Append(" where id=SQL2012id");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            Tapai.Service.Model.dt_users model = new Tapai.Service.Model.dt_users();
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
        public Tapai.Service.Model.dt_users DataRowToModel(DataRow row)
        {
            Tapai.Service.Model.dt_users model = new Tapai.Service.Model.dt_users();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["group_id"] != null && row["group_id"].ToString() != "")
                {
                    model.group_id = int.Parse(row["group_id"].ToString());
                }
                if (row["user_name"] != null)
                {
                    model.user_name = row["user_name"].ToString();
                }
                if (row["password"] != null)
                {
                    model.password = row["password"].ToString();
                }
                if (row["email"] != null)
                {
                    model.email = row["email"].ToString();
                }
                if (row["nick_name"] != null)
                {
                    model.nick_name = row["nick_name"].ToString();
                }
                if (row["avatar"] != null)
                {
                    model.avatar = row["avatar"].ToString();
                }
                if (row["sex"] != null)
                {
                    model.sex = row["sex"].ToString();
                }
                if (row["birthday"] != null && row["birthday"].ToString() != "")
                {
                    model.birthday = DateTime.Parse(row["birthday"].ToString());
                }
                if (row["telphone"] != null)
                {
                    model.telphone = row["telphone"].ToString();
                }
                if (row["mobile"] != null)
                {
                    model.mobile = row["mobile"].ToString();
                }
                if (row["qq"] != null)
                {
                    model.qq = row["qq"].ToString();
                }
                if (row["area"] != null)
                {
                    model.area = row["area"].ToString();
                }
                if (row["address"] != null)
                {
                    model.address = row["address"].ToString();
                }
                if (row["safe_question"] != null)
                {
                    model.safe_question = row["safe_question"].ToString();
                }
                if (row["safe_answer"] != null)
                {
                    model.safe_answer = row["safe_answer"].ToString();
                }
                if (row["amount"] != null && row["amount"].ToString() != "")
                {
                    model.amount = decimal.Parse(row["amount"].ToString());
                }
                if (row["point"] != null && row["point"].ToString() != "")
                {
                    model.point = int.Parse(row["point"].ToString());
                }
                if (row["exp"] != null && row["exp"].ToString() != "")
                {
                    model.exp = int.Parse(row["exp"].ToString());
                }
                if (row["is_lock"] != null && row["is_lock"].ToString() != "")
                {
                    model.is_lock = int.Parse(row["is_lock"].ToString());
                }
                if (row["reg_time"] != null && row["reg_time"].ToString() != "")
                {
                    model.reg_time = DateTime.Parse(row["reg_time"].ToString());
                }
                if (row["reg_ip"] != null)
                {
                    model.reg_ip = row["reg_ip"].ToString();
                }
                if (row["weak"] != null && row["weak"].ToString() != "")
                {
                    model.weak = int.Parse(row["weak"].ToString());
                }
                if (row["referee_mobile"] != null)
                {
                    model.referee_mobile = row["referee_mobile"].ToString();
                }
                if (row["area_id"] != null && row["area_id"].ToString() != "")
                {
                    model.area_id = int.Parse(row["area_id"].ToString());
                }
                if (row["isgive_points"] != null && row["isgive_points"].ToString() != "")
                {
                    if ((row["isgive_points"].ToString() == "1") || (row["isgive_points"].ToString().ToLower() == "true"))
                    {
                        model.isgive_points = true;
                    }
                    else
                    {
                        model.isgive_points = false;
                    }
                }
                if (row["reg_address"] != null)
                {
                    model.reg_address = row["reg_address"].ToString();
                }
                if (row["is_group"] != null && row["is_group"].ToString() != "")
                {
                    if ((row["is_group"].ToString() == "1") || (row["is_group"].ToString().ToLower() == "true"))
                    {
                        model.is_group = true;
                    }
                    else
                    {
                        model.is_group = false;
                    }
                }
                if (row["w_update_time"] != null && row["w_update_time"].ToString() != "")
                {
                    model.w_update_time = DateTime.Parse(row["w_update_time"].ToString());
                }
                if (row["is_test"] != null && row["is_test"].ToString() != "")
                {
                    if ((row["is_test"].ToString() == "1") || (row["is_test"].ToString().ToLower() == "true"))
                    {
                        model.is_test = true;
                    }
                    else
                    {
                        model.is_test = false;
                    }
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
            strSql.Append("select id,group_id,user_name,password,email,nick_name,avatar,sex,birthday,telphone,mobile,qq,area,address,safe_question,safe_answer,amount,point,exp,is_lock,reg_time,reg_ip,weak,referee_mobile,area_id,isgive_points,reg_address,is_group,w_update_time,is_test ");
            strSql.Append(" FROM dt_users ");
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
            strSql.Append(" id,group_id,user_name,password,email,nick_name,avatar,sex,birthday,telphone,mobile,qq,area,address,safe_question,safe_answer,amount,point,exp,is_lock,reg_time,reg_ip,weak,referee_mobile,area_id,isgive_points,reg_address,is_group,w_update_time,is_test ");
            strSql.Append(" FROM dt_users ");
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
            strSql.Append("select count(1) FROM dt_users ");
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
            strSql.Append(")AS Row, T.*  from dt_users T ");
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
			parameters[0].Value = "dt_users";
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

