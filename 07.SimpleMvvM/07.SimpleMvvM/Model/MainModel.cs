using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel; // INotifyPropertyChanged를 가지고 있는 모델
namespace _07.SimpleMvvM.Model
{
    class MainModel : INotifyPropertyChanged
    {
        private int num = 0;
        
        public int Num
        {
            set
            {
                // num의 value값을 변경. num2의 value값을 value * 2로 변경
                num = value;
                Num2 = value * 2;
                // OnPropertyChanged
                // UI에 바인딩된 변수가 변경되었을때
                // UI를 업데이트할 수 있도록 알려주는 함수
                OnPropertyChanged("Num");
            }
            get 
            {
                return num;
            }
        }

        private int num2 = 0;

        public int Num2
        {
            set
            {
                num2 = value;
                OnPropertyChanged("Num2");
            }
            get
            {
                return num2;
            }
        }

        // Interface 구현
        public event PropertyChangedEventHandler? PropertyChanged;

        // 데이터를 UI에 바인딩했을떄 실시간으로 업데이트 함수
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            // 데이터가 바뀌면 handler에 값이 채워짐
            if(handler!=null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
