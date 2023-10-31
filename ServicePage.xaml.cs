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
    /// Логика взаимодействия для ServicePage.xaml
    /// </summary>
    public partial class ServicePage : Page
    {
        public ServicePage()
        {
            InitializeComponent();
            var currentServices = Evdokimov_glazkiEntities.GetContext().Agent.ToList();
            ServiceListView.ItemsSource = currentServices;
            ComboSortSearch.SelectedIndex = 0;
            ComboTypeSearch.SelectedIndex = 0;
            UpdateServices();
        }

        private void UpdateServices()
        {
            var currentServices = Evdokimov_glazkiEntities.GetContext().Agent.ToList();
            currentServices = currentServices.Where(p => (p.Title.ToLower().Contains(TBoxSearch.Text.ToLower()) || p.Email.ToLower().Contains(TBoxSearch.Text.ToLower()) || p.Phone.Replace("+7", "8").Replace("(", "").Replace(") ","").Replace("+7","7").Replace(" ","").Replace("-","").Contains(TBoxSearch.Text.Replace("+7","8").Replace("(", "").Replace(") ", "").Replace(" ", "").Replace("-", "")))).ToList();

            if (ComboSortSearch.SelectedIndex == 0)
                currentServices = currentServices.OrderBy(p => p.Title).ToList();
            if (ComboSortSearch.SelectedIndex == 1)
                currentServices = currentServices.OrderByDescending(p => p.Title).ToList();
            if (ComboSortSearch.SelectedIndex == 2)
                currentServices = currentServices.OrderBy(p => p.Title).ToList();
            if (ComboSortSearch.SelectedIndex == 3)
                currentServices = currentServices.OrderByDescending(p => p.Title).ToList();
            if (ComboSortSearch.SelectedIndex == 4)
                currentServices = currentServices.OrderBy(p => p.Priority).ToList();
            if (ComboSortSearch.SelectedIndex == 5)
                currentServices = currentServices.OrderByDescending(p => p.Priority).ToList();

            if (ComboTypeSearch.SelectedIndex == 0)
                currentServices = currentServices.Where(p => (p.AgentTypeID >= 1 && p.AgentTypeID <=6)).ToList();
            if (ComboTypeSearch.SelectedIndex == 1)
                currentServices = currentServices.Where(p => (p.AgentTypeID == 1)).ToList();
            if (ComboTypeSearch.SelectedIndex == 2)
                currentServices = currentServices.Where(p => (p.AgentTypeID == 2)).ToList();
            if (ComboTypeSearch.SelectedIndex == 3)
                currentServices = currentServices.Where(p => (p.AgentTypeID == 3)).ToList();
            if (ComboTypeSearch.SelectedIndex == 4)
                currentServices = currentServices.Where(p => (p.AgentTypeID == 4)).ToList();
            if (ComboTypeSearch.SelectedIndex == 5)
                currentServices = currentServices.Where(p => (p.AgentTypeID == 5)).ToList();
            if (ComboTypeSearch.SelectedIndex == 6)
                currentServices = currentServices.Where(p => (p.AgentTypeID == 6)).ToList();



            ServiceListView.ItemsSource = currentServices;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage());
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateServices();
        }

        private void ComboTypeSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateServices();
        }

        private void ComboSortSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateServices();
        }

        private void TBoxSearch_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
