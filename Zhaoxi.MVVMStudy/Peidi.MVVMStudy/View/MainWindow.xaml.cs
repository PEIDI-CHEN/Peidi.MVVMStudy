using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Peidi.MVVMStudy.ViewModel;

namespace Peidi.MVVMStudy.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel model = new MainViewModel();

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set
            {
                /// 需要的逻辑 
                myVar = value;

            }
        }

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = model;

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //model.InfoModel.DPName = "Peidi001";



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 为了检查从Model 通知到 View
            //model.InfoModel.Age = 30;
            //model.InfoModel.Name = "Jovan-001";
            //model.InfoModel.DPName = "Peidi001";

            //model.InfoList.Add(new Model.InfoModel { Name = "777", Age = 30 });
            //model.InfoList[0].Name = "777";

            // 为了检查从View 到 Model
            //MessageBox.Show(model.InfoModel.Name);
            //MessageBox.Show(model.InfoModel.DPName);


            //if (this.MyProperty < 0)
            //{
            //    MessageBox.Show("");
            //}


            /// 不管是依赖验证回调返回的异常，还是ValidationRule返回的ValidataResult，还是IDataErrorInfo返回的错误信息
            /// 都会被Validation全局静态类进行捕获
            /// 
            //if (Validation.GetHasError(this.tb))
            //{
            //    var error = Validation.GetErrors(tb);
            //}

        }
    }
}
