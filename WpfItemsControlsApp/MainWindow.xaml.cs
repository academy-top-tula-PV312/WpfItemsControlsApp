using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfItemsControlsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>()
            {
                new(){ Name = "Notebook", Brand = "Asus", Price = 50000 },
                new(){ Name = "Phone", Brand = "Apple", Price = 90000 },
                new(){ Name = "Watch", Brand = "Samsung", Price = 45000 },
            };

            ResourceDictionary dict = new();
            dict.Add("products", products);
            listProducts.Resources = dict;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}