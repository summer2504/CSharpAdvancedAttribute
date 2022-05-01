using System;
using System.Reflection;

namespace AdvancedAttribute2.EnumExtend
{
    public class AttributeInvoke
    {
        public string GetRemark(UserState userState)
        {
            Type type = userState.GetType();
            var fileId = type.GetField(userState.ToString());
            //true 可以进行查找子类
            if (fileId.IsDefined(typeof(RemarkAttribute), true))
            {
                RemarkAttribute remarkAttribute = (RemarkAttribute)fileId.GetCustomAttribute(typeof(RemarkAttribute), true);
                return remarkAttribute.Remark;
            }
            else
            {
                return userState.ToString();
            }
        }
    }
}
