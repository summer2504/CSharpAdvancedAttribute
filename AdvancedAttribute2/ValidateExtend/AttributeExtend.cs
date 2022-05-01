using System;

namespace AdvancedAttribute2.ValidateExtend
{
    public static class AttributeExtend
    {
        public static bool Validate<T>(this T t)
        {
            Type type = t.GetType();
            //属性的验证
            foreach (var property in type.GetProperties())
            {
                if (property.IsDefined(typeof(AbstractValidateAttribute), true))
                {
                    object objValue = property.GetValue(t);
                    foreach (AbstractValidateAttribute attribute in property.GetCustomAttributes(typeof(AbstractValidateAttribute), true))
                    {
                        if (!attribute.Validate(objValue)) //如果成功了之后继续验证，否则直接返回
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
