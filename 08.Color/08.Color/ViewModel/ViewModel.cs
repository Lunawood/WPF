using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _08.Color.ViewModel
{
    class ViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private byte _r, _g, _b;
        private string r = "00", g = "00", b = "00";
        private string color = "";

        public byte R
        {
            get => _r;
            set
            {   // _r의 값이 변환되면 Color의 r값 변경
                if (_r != value)
                {
                    _r = value;
                    r = _r.ToString("X");
                    if (r.Length == 1)
                    {
                        r = "0" + r;
                    }
                    Color = "#" + r + g + b;
                }
            }
        }

        public byte G
        {
            get => _g;
            set
            {   // _g의 값이 변환되면 Color의 g값 변경
                if (_g != value)
                {
                    _g = value;
                    g = _g.ToString("X");
                    if (g.Length == 1)
                    {
                        g = "0" + g;
                    }
                    Color = "#" + r + g + b;
                }
            }
        }

        public byte B
        {
            get => _b;
            set
            {   // _b의 값이 변환디면 Color의 b값 변경
                if (_b != value)
                {
                    _b = value;
                    b = _b.ToString("X");
                    if (b.Length == 1)
                    {
                        b = "0" + b;
                    }
                    Color = "#" + r + g + b;
                }
            }
        }

        public String Color
        {
            get
            {
                return color;
            }
            set
            {
                if (color != value)
                {
                    color = value;
                    _r = BitConverter.GetBytes(Convert.ToInt32(color.Substring(1, 2), 16))[0];
                    _g = BitConverter.GetBytes(Convert.ToInt32(color.Substring(3, 2), 16))[0];
                    _b = BitConverter.GetBytes(Convert.ToInt32(color.Substring(5, 2), 16))[0];
                    r = _r.ToString("X");
                    g = _g.ToString("X");
                    b = _b.ToString("X");
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
