using System;
using System.Diagnostics;

namespace AdvancedAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            UseAttributeClass useAttributeClass = new UseAttributeClass();
            useAttributeClass.DoMethod();

            Console.ReadKey();
        }
    }
  
    public class UseAttributeClass
    {
        //举例适应的特性[DebuggerStepThrough]
        [DebuggerStepThrough]
        public void DoMethod()
        {
            Console.WriteLine("这个方法很简单");
        }
    }
}
