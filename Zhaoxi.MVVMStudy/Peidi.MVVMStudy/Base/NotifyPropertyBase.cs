using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Peidi.MVVMStudy.Base
{
    public class NotifyPropertyBase : INotifyPropertyChanged, IDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RasiePropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public string Error => null;

        /// <summary>
        /// WPF框架底层，会进行处理，自动自动触发  Model实例[Name]
        /// </summary>
        /// <param name="columnName">当前Model类里的属性名称字符串</param>
        /// <returns></returns>
        public string this[string columnName]
        {
            get
            {
                // 不符合逻辑
                //if ((string)this.GetType().GetProperty(columnName).GetValue(this) == "123")
                //{
                //    return "输入值无效[IDataErrorInfo]";
                //}
                // 不优雅
                //if (columnName == "Name" && this.Name == "123")
                //    return "输入值无效[IDataErrorInfo]";


                // 添加System.ComponentModel.DataAnnotations程序集
                // 引用
                /// 第一个参数：object value     属性值：123       需要验证的值 
                /// 第二个参数：验证上下文                         这个值在哪个实例
                /// 第三个参数：错误信息列表                       

                ValidationContext context = new ValidationContext(this);
                context.MemberName = columnName;
                List<ValidationResult> errors = new List<ValidationResult>();

                bool state = Validator.TryValidateProperty(this.GetType().GetProperty(columnName).GetValue(this),
                     context,
                     errors
                     );

                if (errors.Count > 0)
                {
                    return string.Join(Environment.NewLine, errors.Select(e => e.ErrorMessage));
                }

                return "";
            }
        }
    }
}
