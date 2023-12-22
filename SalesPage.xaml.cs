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
    /// Логика взаимодействия для SalesPage.xaml
    /// </summary>
    public partial class SalesPage : Page
    {
        Agent currentAgent;
        public SalesPage(Agent SelectedAgent)
        {
            InitializeComponent();

            currentAgent = SelectedAgent;

            var currentSales = Evdokimov_glazkiEntities1.GetContext().ProductSale.ToList();

            if (SelectedAgent.ID != 0)
            {
                currentSales = currentSales.Where(p => p.AgentID == SelectedAgent.ID).ToList();
            }
            SalesListView.ItemsSource = currentSales;
            DeleteSale.Visibility = Visibility.Collapsed;
        }

        private void UpdateSales()
        {
            var currentSales = Evdokimov_glazkiEntities1.GetContext().ProductSale.ToList();

            if (currentAgent.ID != 0)
            {
                currentSales = currentSales.Where(p => p.Agent.ID == currentAgent.ID).ToList();
            }
            SalesListView.ItemsSource = currentSales;
        }

        private void AddSale_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddSalePage(currentAgent));
        }

        private void DeleteSale_Click(object sender, RoutedEventArgs e)
        {
            List<ProductSale> SelectedSales = SalesListView.SelectedItems.Cast<ProductSale>().ToList();

            foreach (ProductSale currentSales in SelectedSales)
            {
                Evdokimov_glazkiEntities1.GetContext().ProductSale.Remove(currentSales);
            }
            Evdokimov_glazkiEntities1.GetContext().SaveChanges();
            UpdateSales();
        }

        private void SalesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SalesListView.SelectedItems.Count == 0)
                DeleteSale.Visibility = Visibility.Collapsed;
            if (SalesListView.SelectedItems.Count > 0)
                DeleteSale.Visibility = Visibility.Visible;
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateSales();
        }
    }
}
