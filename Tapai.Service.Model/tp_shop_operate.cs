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
namespace Tapai.Service.Model
{
    /// <summary>
    /// tp_shop_operate:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class tp_shop_operate
    {
        public tp_shop_operate()
        { }
        #region Model
        private int _id;
        private int _user_id;
        private string _nick_name;
        private DateTime _addtime;
        private string _remark;
        private int _type;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int user_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string nick_name
        {
            set { _nick_name = value; }
            get { return _nick_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime addtime
        {
            set { _addtime = value; }
            get { return _addtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int type
        {
            set { _type = value; }
            get { return _type; }
        }
        #endregion Model

    }
}

