using System;

namespace AdvancedAttribute1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------创建特性----------------------");
            AttributeTest attributeTest = new AttributeTest();
            attributeTest.Test();
            Console.ReadKey();
        }
    }
    #region 创建特性
    class AttributeTest
    {
        public void Test()
        {
            Type type = typeof(UseAttribute);
            object[] customAttributes = type.GetCustomAttributes(true);
            foreach (object customAttribute in customAttributes)
            {
                DefindAttribute defindAttribute = customAttribute as DefindAttribute;
                if (defindAttribute != null)
                {
                    Console.WriteLine(defindAttribute.ShowInfo);
                }
            }
        }
    }

    [Defind("这是第一个特性的创建！")]
    class UseAttribute
    {

    }
    class DefindAttribute : Attribute
    {
        public DefindAttribute(string showInfo)
        {
            ShowInfo = showInfo;
        }
        public string ShowInfo { get; set; }
    }
    #endregion
}
