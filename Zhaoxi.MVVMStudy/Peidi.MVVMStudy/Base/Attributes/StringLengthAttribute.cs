using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peidi.MVVMStudy.Base.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class StringLengthAttribute : ValidationAttribute
    {
        public int MaxLength { get; set; }
        /// <summary>
        ///  两种IsValid方法，只需要重写一个
        ///  如果两个都重写，以IsValid(object value, ValidationContext validationContext)为准
        ///  IsValid(object value)会被忽略
        /// </summary>
       




        public override bool IsValid(object value)
        {
            if (value != null && value.ToString().Length > MaxLength)
                return false;

            return true;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && value.ToString().Length > MaxLength)
                return new ValidationResult("What the fuck"+this.ErrorMessage);

            return null;
        }
    }
}
