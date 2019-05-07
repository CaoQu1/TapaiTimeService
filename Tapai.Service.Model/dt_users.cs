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
namespace Tapai.Service.Model
{
	/// <summary>
	/// dt_users:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class dt_users
	{
		public dt_users()
		{}
		#region Model
		private int _id;
		private int _group_id=0;
		private string _user_name;
		private string _password;
		private string _email="";
		private string _nick_name="";
		private string _avatar="";
		private string _sex="保密";
		private DateTime? _birthday;
		private string _telphone="";
		private string _mobile="";
		private string _qq="";
		private string _area;
		private string _address;
		private string _safe_question="";
		private string _safe_answer="";
		private decimal? _amount=0M;
		private int? _point=0;
		private int? _exp=0;
		private int? _is_lock=0;
		private DateTime? _reg_time= DateTime.Now;
		private string _reg_ip;
		private int? _weak;
		private string _referee_mobile;
		private int? _area_id;
		private bool _isgive_points;
		private string _reg_address;
		private bool _is_group;
		private DateTime? _w_update_time;
		private bool _is_test;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 用户组别
		/// </summary>
		public int group_id
		{
			set{ _group_id=value;}
			get{return _group_id;}
		}
		/// <summary>
		/// 用户名
		/// </summary>
		public string user_name
		{
			set{ _user_name=value;}
			get{return _user_name;}
		}
		/// <summary>
		/// 用户密码
		/// </summary>
		public string password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 电子邮箱
		/// </summary>
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 用户昵称
		/// </summary>
		public string nick_name
		{
			set{ _nick_name=value;}
			get{return _nick_name;}
		}
		/// <summary>
		/// 用户头像
		/// </summary>
		public string avatar
		{
			set{ _avatar=value;}
			get{return _avatar;}
		}
		/// <summary>
		/// 用户性别
		/// </summary>
		public string sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 生日
		/// </summary>
		public DateTime? birthday
		{
			set{ _birthday=value;}
			get{return _birthday;}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string telphone
		{
			set{ _telphone=value;}
			get{return _telphone;}
		}
		/// <summary>
		/// 手机号码
		/// </summary>
		public string mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// QQ号码
		/// </summary>
		public string qq
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 国家地区
		/// </summary>
		public string area
		{
			set{ _area=value;}
			get{return _area;}
		}
		/// <summary>
		/// 联系地址
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 安全问题
		/// </summary>
		public string safe_question
		{
			set{ _safe_question=value;}
			get{return _safe_question;}
		}
		/// <summary>
		/// 问题答案
		/// </summary>
		public string safe_answer
		{
			set{ _safe_answer=value;}
			get{return _safe_answer;}
		}
		/// <summary>
		/// 预存款
		/// </summary>
		public decimal? amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 用户积分
		/// </summary>
		public int? point
		{
			set{ _point=value;}
			get{return _point;}
		}
		/// <summary>
		/// 经验值
		/// </summary>
		public int? exp
		{
			set{ _exp=value;}
			get{return _exp;}
		}
		/// <summary>
		/// 用户状态,0正常,1待验证,2待审核,3锁定
		/// </summary>
		public int? is_lock
		{
			set{ _is_lock=value;}
			get{return _is_lock;}
		}
		/// <summary>
		/// 注册时间
		/// </summary>
		public DateTime? reg_time
		{
			set{ _reg_time=value;}
			get{return _reg_time;}
		}
		/// <summary>
		/// 注册IP
		/// </summary>
		public string reg_ip
		{
			set{ _reg_ip=value;}
			get{return _reg_ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? weak
		{
			set{ _weak=value;}
			get{return _weak;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string referee_mobile
		{
			set{ _referee_mobile=value;}
			get{return _referee_mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? area_id
		{
			set{ _area_id=value;}
			get{return _area_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isgive_points
		{
			set{ _isgive_points=value;}
			get{return _isgive_points;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string reg_address
		{
			set{ _reg_address=value;}
			get{return _reg_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool is_group
		{
			set{ _is_group=value;}
			get{return _is_group;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? w_update_time
		{
			set{ _w_update_time=value;}
			get{return _w_update_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool is_test
		{
			set{ _is_test=value;}
			get{return _is_test;}
		}
		#endregion Model

	}
}

