using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Peidi.MVVMStudy.Base;
using Peidi.MVVMStudy.Model;

namespace Peidi.MVVMStudy.ViewModel
{
    public class MainViewModel
    {
        //List<InfoModel> infoList = new List<InfoModel>();
        //private List<InfoModel> _infoModels=new List<InfoModel>();

        //public List<InfoModel> infoList
        //{
        //    get { return _infoModels; }
        //    set
        //    {
        //        _infoModels = value;
        //        this.RasiePropertyChanged();
        //    }
        //}
        public ObservableCollection<InfoModel> InfoList { get; set; } = new ObservableCollection<InfoModel>();

        public InfoModel InfoModel { get; set; }
        public MainViewModel()
        {
            //InfoModel = new InfoModel() { Name = "Jovan", Age = 28 ,DPName="Peidi"};
            InfoModel = new InfoModel() { Name = "Jovan", Age = 28 };

            InfoList.Add(new InfoModel { Name = "111", Age = 28 });
            InfoList.Add(new InfoModel { Name = "222", Age = 28 });
            InfoList.Add(new InfoModel { Name = "333", Age = 28 });
            InfoList.Add(new InfoModel { Name = "444", Age = 28 });
            InfoList.Add(new InfoModel { Name = "555", Age = 28 });
            InfoList.Add(new InfoModel { Name = "666", Age = 28 });
        }
    }
}
