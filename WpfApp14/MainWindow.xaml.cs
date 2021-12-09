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
using System.Collections.ObjectModel;

namespace WpfApp14
{

    public partial class MainWindow : Window
    {

        public ObservableCollection<Product> products;

        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>
                {
                    new Product { NameProduct = "Батон", PriceProduct = 45, ImageProduct = @"Data\baton.png", CategoryProduct = Categories.Food },
                    new Product { NameProduct = "Сыр", PriceProduct = 120, ImageProduct = @"Data\sr.png", CategoryProduct = Categories.Food },
                    new Product { NameProduct = "Холодильник", PriceProduct = 8999, ImageProduct = @"Data\holod.png", CategoryProduct = Categories.Appliances },
                    new Product { NameProduct = "Телевизор", PriceProduct = 109999, ImageProduct = @"Data\tele.png", CategoryProduct = Categories.Appliances }
                };

            listBox.ItemsSource = products;
        }
    }

}
