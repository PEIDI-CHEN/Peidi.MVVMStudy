using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Peidi.MVVMStudy.Base;
using Peidi.MVVMStudy.Base.Attributes;
//using System.ComponentModel.

namespace Peidi.MVVMStudy.Model
{
    public class InfoModel : NotifyPropertyBase
    {
        //public event EventHandler NameChanged;
        //private string _name;

        //public string Name
        //{
        //    get { return _name; }
        //    set
        //    {
        //        _name = value;
        //        NameChanged?.Invoke(this, null);
        //    }
        //}

        //public event EventHandler AgeChanged;
        //private int _age;

        //public int Age
        //{
        //    get { return _age; }
        //    set
        //    {
        //        _age = value;
        //        NameChanged?.Invoke(this, null);
        //    }
        //}


        //public string DPName
        //{
        //    get { return (string)GetValue(DPNameProperty); }
        //    set { SetValue(DPNameProperty, value); }
        //}
        //public static readonly DependencyProperty DPNameProperty =
        //    DependencyProperty.Register("DPName", typeof(string), typeof(InfoModel), new PropertyMetadata(default(string)));


        //[StringLength(10, MinimumLength = 2, ErrorMessage = "输入内容不合法")]
        private string _name;
        [Required(ErrorMessage = "Name字段为必输项，不能为空")]
        [Base.Attributes.StringLength(MaxLength = 10, ErrorMessage = "自定义校验错误")]
        [RegularExpression(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "邮箱格式不正确")]
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                this.RasiePropertyChanged();


                //if (value == "123")
                //{
                //    throw new ApplicationException("输入值无效");
                //}
                //else if (value == "111")
                //{
                //    throw new ApplicationException("输入值无效111");
                //}
            }
        }

        private int _age;
        //[Range(0, 90, ErrorMessage = "年龄超出限定")]
        [Phone(ErrorMessage ="wefwfwef")]
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                this.RasiePropertyChanged();
            }
        }

        public static class StaticModel
        {
            public static event EventHandler<PropertyChangedEventArgs> StaticPropertyChanged;
            private static int myVar;

            public static int MyProperty
            {
                get { return myVar; }
                set
                {
                    myVar = value;
                    StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs("MyProperty"));
                }
            }

        }
    }
}
