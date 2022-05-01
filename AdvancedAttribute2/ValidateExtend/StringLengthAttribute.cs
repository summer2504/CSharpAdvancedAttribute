using System;

namespace AdvancedAttribute2.ValidateExtend
{
    [AttributeUsage(AttributeTargets.Property)]
    public class StringLengthAttribute : AbstractValidateAttribute
    {
        private int _Mni = 0;
        private int _Max = 0;
        public StringLengthAttribute(int max, int min)
        {
            this._Max = max;
            this._Mni = min;
        }
        public override bool Validate(object objValue)
        {
            return objValue != null && objValue.ToString().Length > this._Mni && objValue.ToString().Length < this._Max;
        }
    }
}
