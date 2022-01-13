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

namespace Lab14WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                Name = "Бургер",
                Price = 500,
                Category = Categories.Food,
                Image="Data/burger.jpg"
            });
            products.Add(new Product()
            {
                Name = "Coca-Cola",
                Price = 150,
                Category = Categories.Food,
                Image = "Data/coca.jpg"
            });
            products.Add(new Product()
            {
                Name = "Холодильник",
                Price = 200000,
                Category = Categories.Appliances,
                Image = "Data/ref.jpg"
            });
            lstBox.ItemsSource = products;
        }
    }
}
