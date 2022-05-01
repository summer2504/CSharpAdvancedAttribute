namespace AdvancedAttribute2.ShowExtend
{
    [Show(ShowInfo = "我是在类上的特性")]
    [Show(ShowInfo = "我是在类上的第二个特性")]
    public class ShowTest
    {
        [Show(ShowInfo = "我是在方法上的特性")]
        public void Test()
        { }
        [Show(ShowInfo = "我是在属性上的特性---------")]
        public string TestProperty { get; set; }//属性
        [Show(ShowInfo = "我是在字段上的特性========")]
        public string TestFiled;//字段
    }
}
