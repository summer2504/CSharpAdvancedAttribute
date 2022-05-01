using System;

namespace AdvancedAttribute2.ValidateExtend
{
    public abstract class AbstractValidateAttribute : Attribute
    {
        public abstract bool Validate(object Value);
    }
}
