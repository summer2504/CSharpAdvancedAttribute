using System;
using System.Reflection;

namespace AdvancedAttribute2.ShowExtend
{
    public class InvokeConter
    {
        public void InvokeManager<T>(T showTest) where T : new()
        {
            Type type = showTest.GetType();//获取类型
            if (type.IsDefined(typeof(ShowAttribute), true))
            {
                //在类上面查找特性
                object[] attributes = type.GetCustomAttributes(typeof(ShowAttribute), true);
                foreach (ShowAttribute attribute in attributes)
                {
                    attribute.Show();
                }
                //在方法上查找
                foreach (MethodInfo method in type.GetMethods())
                {
                    if (method.IsDefined(typeof(ShowAttribute), true))
                    {
                        object[] attributeMethodInfos = method.GetCustomAttributes(typeof(ShowAttribute), true);
                        foreach (ShowAttribute attribute in attributeMethodInfos)
                        {
                            attribute.Show();
                        }
                    }
                }
                //在属性上查找
                foreach (PropertyInfo propertyInfo in type.GetProperties())
                {
                    if (propertyInfo.IsDefined(typeof(ShowAttribute), true))
                    {
                        object[] attributePropertyInfos = propertyInfo.GetCustomAttributes(typeof(ShowAttribute), true);
                        foreach (ShowAttribute attribute in attributePropertyInfos)
                        {
                            attribute.Show();
                        }
                    }
                }
                //在字段上查找
                foreach (FieldInfo fieldInfo in type.GetFields())
                {
                    if (fieldInfo.IsDefined(typeof(ShowAttribute), true))
                    {
                        object[] attributefieldInfos = fieldInfo.GetCustomAttributes(typeof(ShowAttribute), true);
                        foreach (ShowAttribute attribute in attributefieldInfos)
                        {
                            attribute.Show();
                        }
                    }
                }
            }
        }
    }
}
