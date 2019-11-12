using System;
using System.Collections.Generic;

namespace Tapai.Service.Model
{
    /// <summary>
    /// 经销商的门店信息
    /// 经销商信息在会员-类型为经销里
    /// </summary>
    public class dealer_level_object
    {
        private int _dealer_id;
        private int _user_id;
        private int _parent_id;
        private string _sys_code;
        private string _shop_name;
        private string _longitude;
        private string _latitude;
        private bool _exchange;
        private string _address;
        private int _dealer_lev;
        private string _contacter;
        private string _business_time_start;
        private string _business_time_end;
        private string _tel;
        private string _desc_txt;
        private string _shop_photo;
        private int _status;
        private bool? _is_shop;
        private bool? _is_engineering;

        /// <summary>
        /// 主键-经销商门店ID
        /// </summary>
        public int Dealer_id
        {
            get { return _dealer_id; }
            set { _dealer_id = value; }
        }

        /// <summary>
        /// 对应的会员ID
        /// </summary>
        public int User_id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }
        /// <summary>
        /// 父级门店ID
        /// </summary>
        public int Parent_id
        {
            get { return _parent_id; }
            set { _parent_id = value; }
        }

        /// <summary>
        /// 门店名称
        /// </summary>
        public string Shop_name
        {
            get { return _shop_name; }
            set { _shop_name = value; }
        }

        /// <summary>
        /// 门店系统编码
        /// </summary>
        public string Sys_code
        {
            get { return _sys_code; }
            set { _sys_code = value; }
        }

        /// <summary>
        /// 经度
        /// </summary>
        public string Longitude
        {
            get { return _longitude; }
            set { _longitude = value; }
        }

        /// <summary>
        /// 纬度
        /// </summary>
        public string Latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }

        /// <summary>
        /// 可否兑换积分
        /// </summary>
        public bool Exchange
        {
            get { return _exchange; }
            set { _exchange = value; }
        }

        /// <summary>
        /// 门店地址
        /// </summary>
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// 经销商级别
        /// </summary>
        public int Dealer_lev
        {
            get { return _dealer_lev; }
            set { _dealer_lev = value; }
        }

        /// <summary>
        /// 联系人
        /// </summary>
        public string Contacter
        {
            get { return _contacter; }
            set { _contacter = value; }
        }

        /// <summary>
        /// 营业开始时间
        /// </summary>
        public string Business_time_start
        {
            get { return _business_time_start; }
            set { _business_time_start = value; }
        }

        /// <summary>
        /// 营业结束时间
        /// </summary>
        public string Business_time_end
        {
            get { return _business_time_end; }
            set { _business_time_end = value; }
        }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        /// <summary>
        /// 门店描述
        /// </summary>
        public string Desc_txt
        {
            get { return _desc_txt; }
            set { _desc_txt = value; }
        }

        /// <summary>
        /// 店铺图片
        /// </summary>
        public string Shop_photo
        {
            get { return _shop_photo; }
            set { _shop_photo = value; }
        }

        /// <summary>
        /// 经销商门店状态，1：正常，2：待审核，3：不可用
        /// </summary>
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// 是否是导购
        /// </summary>
        public bool? is_shop
        {
            get { return _is_shop; }
            set { _is_shop = value; }
        }

        /// <summary>
        /// 是否是工程商家
        /// </summary>
        public bool? is_engineering
        {
            get
            {
                return _is_engineering;
            }
            set
            {
                _is_engineering = value;
            }
        }

        public IList<dealer_level_object> children = new List<dealer_level_object>();

        public int group_id { get; set; }

        public string nick_name { get; set; }

        public string mobile { get; set; }

        public int area_id { get; set; }

        public string user_name { get; set; }
    }
}