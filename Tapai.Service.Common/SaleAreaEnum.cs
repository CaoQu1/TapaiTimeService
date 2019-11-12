using System;
using System.ComponentModel;

namespace Tapai.Service.Common
{
    /// <summary>
    /// 区域强弱势
    /// </summary>
    public enum SaleAreaEnum
    {
        /// <summary>
        /// 强势
        /// </summary>
        [System.ComponentModel.Description("强势区域")]
        Strong = 0,

        /// <summary>
        /// 弱势
        /// </summary>
        [System.ComponentModel.Description("弱势区域")]
        Weak = 1,

        /// <summary>
        /// 促销
        /// </summary>
        [System.ComponentModel.Description("促销区域")]
        Promotion = 2,

        /// <summary>
        /// 不积分
        /// </summary>
        [System.ComponentModel.Description("不积分区域")]
        NotInterGral = 3,

        /// <summary>
        /// 临时促销
        /// </summary>
        [System.ComponentModel.Description("临时促销区域")]
        TmpPromotion = 4,

        /// <summary>
        /// 待用
        /// </summary>
        [System.ComponentModel.Description("待用区域")]
        ToUsed = 5,

        /// <summary>
        /// 特殊区域1
        /// </summary>
        [System.ComponentModel.Description("特殊区域1")]
        SpecialOne = 6,

        /// <summary>
        /// 特殊区域2
        /// </summary>
        [System.ComponentModel.Description("特殊区域2")]
        SpecialTwo = 7

    }

    /// <summary>
    /// 系统状态
    /// </summary>
    public enum EnumStatus
    {
        /// <summary>
        /// 正常
        /// </summary>
        Nomal = 0,

        /// <summary>
        /// 禁用
        /// </summary>
        Disable = 1
    }

    /// <summary>
    /// 水电工星级
    /// </summary>
    public enum EnumStarType
    {
        /// <summary>
        /// 水电工星级
        /// </summary>
        Ele = 1,

        /// <summary>
        /// 商家星级
        /// </summary>
        Busless = 2
    }

    /// <summary>
    /// 会员状态
    /// </summary>
    public enum EnumUserStatus
    {
        /// <summary>
        /// 正常
        /// </summary>
        [Description("正常")]
        Normal = 0,

        /// <summary>
        /// 待验证
        /// </summary>
        [Description("待验证")]
        Validate = 1,

        /// <summary>
        /// 待审核
        /// </summary>
        [Description("待审核")]
        Approval = 2,

        /// <summary>
        /// 禁用
        /// </summary>
        [Description("禁用")]
        Disabled = 3
    }

    /// <summary>
    /// 设置导购类型
    /// </summary>
    public enum EnumShopRecordType
    {
        /// <summary>
        /// 手动
        /// </summary>
        [Description("手动")]
        Manual = 1,

        /// <summary>
        /// 自动
        /// </summary>
        [Description("自动")]
        Automatic = 2
    }

    /// <summary>
    /// 导购获取积分的地址是否正常
    /// </summary>
    public enum EnumShopRecordStatus
    {
        /// <summary>
        /// 正常
        /// </summary>
        [Description("正常")]
        Normal = 1,

        /// <summary>
        /// 异常
        /// </summary>
        [Description("异常")]
        Abnormal = 2
    }
}
