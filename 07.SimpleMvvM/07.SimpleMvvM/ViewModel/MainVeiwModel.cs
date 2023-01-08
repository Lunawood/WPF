using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SimpleMvvM.ViewModel
{
    class MainVeiwModel : INotifyPropertyChanged
    {
        // MainModel 객체 생성, Model과 ViewModel 연결
        private Model.MainModel model = null;
        
        public MainVeiwModel()
        {
            model = new Model.MainModel();
        }
        public Model.MainModel Model
        {
            set { model = value; OnPropertyChanged("Model"); }
            get { return model; }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
