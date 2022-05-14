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
using System.Windows.Shapes;

namespace ProteinShop
{
  
    
    public partial class ShopWindow : Window
    {
        private MainViewModel MainViewModel { get; set; } = new MainViewModel();
        public ShopWindow()
        {
            InitializeComponent();
            DataContext = MainViewModel;
            
         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var rowItem = (sender as Button).DataContext as ImageViewModel;
            string drinks = "";
            drinks += rowItem.Name + "\n";

            using (UserDataContext context = new UserDataContext())

            {
                Random rnd = new Random();
                int order = rnd.Next();
                Cart cart = new Cart(order, drinks, rowItem.Price);

                context.Carts.Add(cart);
                context.SaveChanges();








                MessageBox.Show($"Товар {rowItem.Name} успешно добавлен в корзину");



            }
        }

        private void Cart_Click(object sender, RoutedEventArgs e)
        {
            CartWindow cartWindow = new CartWindow();
            cartWindow.Show();
            Hide();

        }
    }
}
