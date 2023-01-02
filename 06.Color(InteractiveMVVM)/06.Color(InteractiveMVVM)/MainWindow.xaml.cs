using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace _06.Color_InteractiveMVVM_
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private byte _r, _g, _b;
        private Color _color;
        
        public MainWindow()
        {
            InitializeComponent();
        }
        public byte R
        {
            get => _r;
            set
            {   // _hue의 값이 변환되면 Color의 _hue값 변경
                if (_r != value)
                    Color = Color.FromRgb(value, _g, _b);
            }
        }

        public byte G
        {
            get => _g;
            set
            {   // _saturation의 값이 변환되면 Color의 _saturation값 변경
                if (_g != value)
                    Color = Color.FromRgb(_r, value, _b);
            }
        }

        public byte B
        {
            get => _b;
            set
            {   // _luminosity의 값이 변환디면 Color의 _luminosity값 변경
                if (_b != value)
                    Color = Color.FromRgb(_r, _g, value);
            }
        }

        public Color Color
        {
            get => _color;
            set
            {   // _color 값이 변경되면 각각의 _color의 값들이 _hue, _saturation, _luminosity변경
                if (_color != value)
                {
                    _color = value;
                    _r = Convert.ToByte(_color.GetNativeColorValues().ElementAt(0) % 256);
                    _g = Convert.ToByte(_color.GetNativeColorValues().ElementAt(1) % 256); ;
                    _b = Convert.ToByte(_color.GetNativeColorValues().ElementAt(2) % 256); ;

                    OnPropertyChanged("R");
                    OnPropertyChanged("G");
                    OnPropertyChanged("B");
                    OnPropertyChanged(); // reports this property
                }
            }
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
