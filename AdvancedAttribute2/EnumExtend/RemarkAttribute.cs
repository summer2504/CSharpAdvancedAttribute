using System;

namespace AdvancedAttribute2.EnumExtend
{
    /// <summary>
    /// 特性上面也可以添加特性 
    /// </summary>
    [AttributeUsage(AttributeTargets.Field,AllowMultiple =true)]//标记在字段上
    public class RemarkAttribute : Attribute
    {
        /// <summary>
        /// 状态特性
        /// </summary>
        /// <param name="remark"></param>
        public RemarkAttribute(string remark)
        {
            this.Remark = remark;
        }
        public string Remark { get; set; }//属性
    }
}
