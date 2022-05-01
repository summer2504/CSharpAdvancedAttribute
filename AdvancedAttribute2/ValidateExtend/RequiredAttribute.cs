using System;

namespace AdvancedAttribute2.ValidateExtend
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredAttribute : AbstractValidateAttribute
    {
        public override bool Validate(object objValue)
        {
            return objValue != null && !string.IsNullOrWhiteSpace(objValue.ToString());
        }
    }
}
