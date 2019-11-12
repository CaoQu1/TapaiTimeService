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
using Tapai.Service.Common;

namespace Tapai.Service.Model
{
	/// <summary>
	/// tp_shop_brush:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tp_shop_brush
	{
		public tp_shop_brush()
		{}
		#region Model
		private int _user_id;
		private string _nick_name;
		private string _scan_year;
		private string _scan_month;
		private string _scan_day;
		private EnumShopRecordStatus _status;
		private string _code;
		/// <summary>
		/// 
		/// </summary>
		public int user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string nick_name
		{
			set{ _nick_name=value;}
			get{return _nick_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string scan_year
		{
			set{ _scan_year=value;}
			get{return _scan_year;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string scan_month
		{
			set{ _scan_month=value;}
			get{return _scan_month;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string scan_day
		{
			set{ _scan_day=value;}
			get{return _scan_day;}
		}
		/// <summary>
		/// 
		/// </summary>
		public EnumShopRecordStatus status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string code
		{
			set{ _code=value;}
			get{return _code;}
		}
		#endregion Model

	}
}

