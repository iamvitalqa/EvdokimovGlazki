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

namespace EvdokimovGlazki
{
    /// <summary>
    /// Логика взаимодействия для AddSalePage.xaml
    /// </summary>
    public partial class AddSalePage : Page
    {
        public List<Product> currentProduct = new List<Product>(Evdokimov_glazkiEntities1.GetContext().Product.ToList());
        private ProductSale currentProductSale = new ProductSale();
        Agent currentAgent;
        public AddSalePage(Agent SelectedAgent)
        {
            InitializeComponent();
            currentAgent = SelectedAgent;
            
            ProductsComboBox.ItemsSource = currentProduct;
            DataContext = currentProductSale;
        }

        private void ProductsComboBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ProductsComboBox.IsDropDownOpen = true;
            
            currentProduct = currentProduct.Where(p => p.Title.ToLower().Contains(ProductsComboBox.Text.ToLower())).ToList();
            ProductsComboBox.ItemsSource = currentProduct;
        }

        private void SaveSaleButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            var a = Convert.ToInt32(ProductCount.Text);
            if (a <= 0)
                errors.AppendLine("Добавьте количество");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            currentProductSale.ID = 0;
            currentProductSale.AgentID = currentAgent.ID;

            if (ProductsComboBox.SelectedIndex != -1)
            {
                currentProductSale.ProductID = currentProduct[ProductsComboBox.SelectedIndex].ID;
            }
            else
            {
                currentProductSale.ProductID = currentProduct[0].ID;
            }


            if (ProductSaleDate.Text != "" && Convert.ToDateTime(ProductSaleDate.Text) != null)
            {
                currentProductSale.SaleDate = Convert.ToDateTime(ProductSaleDate.Text);
            }
            else
            {
                currentProductSale.SaleDate = DateTime.Now;
            }

            currentProductSale.ProductCount = Convert.ToInt32(ProductCount.Text);

            
      
            Evdokimov_glazkiEntities1.GetContext().ProductSale.Add(currentProductSale);
            Evdokimov_glazkiEntities1.GetContext().SaveChanges();
            MessageBox.Show("Информация сохранена");
            Manager.MainFrame.GoBack();

           
        }
    }
}
