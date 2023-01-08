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

namespace BikeShop
{
    /// <summary>
    /// ProductsManagement.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ProductsManagement : Page
    {
        ProductsFactory factory = new ProductsFactory();

        public ProductsManagement()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // textBox 텍스트가 변경이 되면 dataGrid의 항목 데이터를 의미하는
            // ItemsSource에 factory라는 100개의 제품목록 중에서 textBox에 입력된
            // 텍스트로 Find를 해서 필터링된 데이터를 ItemsSource에 대입
            dataGrid.ItemsSource = factory.FindProducts(textBox.Text); 

        }
    }
}
