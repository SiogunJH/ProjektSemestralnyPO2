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
using System.Data.Entity;

namespace WPF_Game_Store_App.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy Home.xaml
    /// </summary>
    public partial class BrowseAllVideoGames : Page
    {
        GameStoreDBEntities context = new GameStoreDBEntities();
        CollectionViewSource products;
        public BrowseAllVideoGames()
        {
            InitializeComponent();
            Loaded += Page_Loaded;

            products = ((CollectionViewSource)(FindResource("productsViewSource")));
            DataContext = this;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            context.Products.Load();
            products.Source = context.Products.Local;
        }
        private void ButtonNotImplemented(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Click");
        }
    }
}
