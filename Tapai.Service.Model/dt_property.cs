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
namespace Tapai.Service.Model
{
	/// <summary>
	/// 用户组
	/// </summary>
	[Serializable]
	public partial class dt_property
	{
		public dt_property()
		{}
		#region Model
		private int _id;
		private string _property_key;
		private string _property_value;
		private string _name;
		private string _description;
		private string _tags;
		private string _admin_name;
		private int _admin_id=0;
		private string _admin_real_name;
		private DateTime _add_time= DateTime.Now;
		private DateTime _update_time= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string property_key
		{
			set{ _property_key=value;}
			get{return _property_key;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string property_value
		{
			set{ _property_value=value;}
			get{return _property_value;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tags
		{
			set{ _tags=value;}
			get{return _tags;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string admin_name
		{
			set{ _admin_name=value;}
			get{return _admin_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int admin_id
		{
			set{ _admin_id=value;}
			get{return _admin_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string admin_real_name
		{
			set{ _admin_real_name=value;}
			get{return _admin_real_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime add_time
		{
			set{ _add_time=value;}
			get{return _add_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime update_time
		{
			set{ _update_time=value;}
			get{return _update_time;}
		}
		#endregion Model

	}
}

