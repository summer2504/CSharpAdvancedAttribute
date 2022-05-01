using AdvancedAttribute2.EnumExtend;
using AdvancedAttribute2.ShowExtend;
using AdvancedAttribute2.ValidateExtend;
using System;

namespace AdvancedAttribute2
{
    class Program
    {
        static void Main(string[] args)
        {
            //实验一
            UserState userState = UserState.Frozen;
            if (userState == UserState.Normal)
            {
                Console.WriteLine("正常");
            }
            else if (userState == UserState.Frozen)
            {
                Console.WriteLine("冻结");
            }
            else if (userState == UserState.Delete)
            {
                Console.WriteLine("删除");
            }
            //通过特性来操作
            Console.WriteLine("--------------------通过特性来操作--------------------");
            AttributeInvoke attributeInvoke = new AttributeInvoke();
            Console.WriteLine(attributeInvoke.GetRemark(userState));


            Console.WriteLine("--------------------实验二普通方式--------------------");
            ShowTest showTest = new ShowTest();
            InvokeConter invokeConter = new InvokeConter();
            invokeConter.InvokeManager(showTest);
            Console.WriteLine("--------------------实验二扩展方法--------------------");
            ShowTest showTest1 = new ShowTest();
            showTest1.InvokeManager();
            Console.WriteLine("--------------------实验三扩展方法--------------------");
            Student student = new Student()
            {
                Id = 1,
                PhoneNumber = 12345678900,
                StudentName = "Ant1编程"
            };
            if (student.Validate())
            {
                Console.WriteLine("验证成功");
            }
            else
            {
                Console.WriteLine("验证失败");
            }
            Console.ReadKey();
        }
    }
}
