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
namespace Tapai.Service.Model
{
    /// <summary>
    /// dt_point_log:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class dt_point_log
    {
        public dt_point_log()
        { }
        #region Model
        private int _id;
        private int? _user_id;
        private string _user_name;
        private int? _value;
        private string _remark;
        private DateTime? _add_time = DateTime.Now;
        private int? _rest_value;
        private int? _state;
        private int? _area_attr;
        private int? _type;
        private string _code;
        private string _scan_location;
        private string _latitude;
        private string _longitude;
        private string _scan_ip;
        private string _scan_ip_address;
        /// <summary>
        /// 自增ID
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int? user_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string user_name
        {
            set { _user_name = value; }
            get { return _user_name; }
        }
        /// <summary>
        /// 增减积分
        /// </summary>
        public int? value
        {
            set { _value = value; }
            get { return _value; }
        }
        /// <summary>
        /// 备注说明
        /// </summary>
        public string remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime? add_time
        {
            set { _add_time = value; }
            get { return _add_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? rest_value
        {
            set { _rest_value = value; }
            get { return _rest_value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? state
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? area_attr
        {
            set { _area_attr = value; }
            get { return _area_attr; }
        }
        /// <summary>
        /// 获取积分的类别标识
        /// 1: 注册送积分，
        /// 2：水电工扫码获积分；
        /// 3：经销商扫代金券获积分；
        /// 4：系统赠送积分；
        /// 5: 邀请他人注册获得积分
        /// 6: 购物获得积分
        /// 7: 升级获得积分；
        /// 8：扣减的积分(主动兑换代金券,兑换商品)；
        /// 9：代表积分来源为其他经销商向其兑换而得；
        /// 10：取消订单，返还换购积分
        /// 11：水电管扫码邀请人获得积分
        /// 12：水电工积分到期清零
        /// </summary>
        public int? type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string code
        {
            set { _code = value; }
            get { return _code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string scan_location
        {
            set { _scan_location = value; }
            get { return _scan_location; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string latitude
        {
            set { _latitude = value; }
            get { return _latitude; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string longitude
        {
            set { _longitude = value; }
            get { return _longitude; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string scan_ip
        {
            set { _scan_ip = value; }
            get { return _scan_ip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string scan_ip_address
        {
            set { _scan_ip_address = value; }
            get { return _scan_ip_address; }
        }
        #endregion Model

    }
}

