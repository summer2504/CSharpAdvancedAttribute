using System;

namespace AdvancedAttribute2.ShowExtend
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]//所有的地方都可以使用|多重标记
    public class ShowAttribute : Attribute
    {
        public string ShowInfo { get; set; }
        public void Show()
        {
            Console.WriteLine(ShowInfo);
        }
    }
}
