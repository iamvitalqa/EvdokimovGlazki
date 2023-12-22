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
        int CountRecords;
        int CountPage;
        int CurrentPage = 0;

        List<Agent> CurrentPageList = new List<Agent>();
        List<Agent> TableList;

        public ServicePage()
        {
            InitializeComponent();
            var currentServices = Evdokimov_glazkiEntities1.GetContext().Agent.ToList();
            ServiceListView.ItemsSource = currentServices; 
            ComboSortSearch.SelectedIndex = 0;
            ComboTypeSearch.SelectedIndex = 0;
            UpdateServices();
        }

        private void UpdateServices()
        {
            var currentServices = Evdokimov_glazkiEntities1.GetContext().Agent.ToList();
            currentServices = currentServices.Where(p => (p.Title.ToLower().Contains(TBoxSearch.Text.ToLower()) || p.Email.ToLower().Contains(TBoxSearch.Text.ToLower()) || p.Phone.Replace("+7", "8").Replace("(", "").Replace(") ","").Replace("+7","7").Replace(" ","").Replace("-","").Contains(TBoxSearch.Text.Replace("+7","8").Replace("(", "").Replace(") ", "").Replace(" ", "").Replace("-", "")))).ToList();

            if (ComboSortSearch.SelectedIndex == 0)
                currentServices = currentServices.OrderBy(p => p.Title).ToList();
            if (ComboSortSearch.SelectedIndex == 1)
                currentServices = currentServices.OrderByDescending(p => p.Title).ToList();
            if (ComboSortSearch.SelectedIndex == 2)
                currentServices = currentServices.OrderBy(p => p.SaleProduct).ToList();
            if (ComboSortSearch.SelectedIndex == 3)
                currentServices = currentServices.OrderByDescending(p => p.SaleProduct).ToList();
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

            TableList = currentServices;
            ChangePage(0, 0);

        }

        private void ChangePage(int direction, int? selectedPage)
        {
            CurrentPageList.Clear();
            CountRecords = TableList.Count;
            if (CountRecords % 10 > 0)
            {
                CountPage = CountRecords / 10 + 1;
            }
            else
            {
                CountPage = CountRecords / 10;
            }

            Boolean Ifupdate = true;
            int min;
            if (selectedPage.HasValue)
            {
                if (selectedPage >= 0 && selectedPage <= CountPage)
                {
                    CurrentPage = (int)selectedPage;
                    min = CurrentPage * 10 + 10 < CountRecords ? CurrentPage * 10 + 10 : CountRecords;
                    for (int i = CurrentPage * 10; i < min; i++)
                    {
                        CurrentPageList.Add(TableList[i]);
                    }
                }
            }
            else
            {
                switch (direction)
                {
                    case 1:
                        if (CurrentPage > 0)
                        {
                            CurrentPage--;
                            min = CurrentPage * 10 + 10 < CountRecords ? CurrentPage * 10 + 10 : CountRecords;
                            for (int i = CurrentPage * 10; i < min; i++)
                            {
                                CurrentPageList.Add(TableList[i]);
                            }
                        }
                        else
                        {
                            Ifupdate = false;
                        }
                        break;

                    case 2:
                        if (CurrentPage < CountPage - 1)
                        {
                            CurrentPage++;
                            min = CurrentPage * 10 + 10 < CountRecords ? CurrentPage * 10 + 10 : CountRecords;
                            for (int i = CurrentPage * 10; i < min; i++)
                            {
                                CurrentPageList.Add(TableList[i]);
                            }
                        }
                        else
                        {
                            Ifupdate = false;
                        }
                        break;
                }


            }
            if (Ifupdate)
            {
                PageListBox.Items.Clear();
                for (int i = 1; i <= CountPage; i++)
                {
                    PageListBox.Items.Add(i);
                }
                PageListBox.SelectedIndex = CurrentPage;


                ServiceListView.ItemsSource = CurrentPageList;
                ServiceListView.Items.Refresh();
            }

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

        private void LeftDirButton_Click(object sender, RoutedEventArgs e)
        {
            ChangePage(1, null);
        }

        private void RightDirButton_Click(object sender, RoutedEventArgs e)
        {
            ChangePage(2, null);
        }

        private void PageListBox_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ChangePage(0, Convert.ToInt32(PageListBox.SelectedItem.ToString()) - 1);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage(null));
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage((sender as Button).DataContext as Agent));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Evdokimov_glazkiEntities1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                ServiceListView.ItemsSource = Evdokimov_glazkiEntities1.GetContext().Agent.ToList();
            }
        }

        private void ServiceListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ServiceListView.SelectedItems.Count > 1)
            {
                chngpriority.Visibility = Visibility.Visible;
            }
            else
            {
                chngpriority.Visibility = Visibility.Hidden;
            }
        }

        private void chngpriority_Click(object sender, RoutedEventArgs e)
        {

            int max = 0;
            foreach (Agent agent in ServiceListView.SelectedItems)
            {
                if(agent.Priority >= max)
                {
                    max = agent.Priority;
                }
            }

            prioritycng Window = new prioritycng(max);
            Window.ShowDialog();
            if (string.IsNullOrEmpty(Window.textpriority.Text))
            {
                return;
            }
            foreach (Agent AgentLV in ServiceListView.SelectedItems)
            {
                AgentLV.Priority = Convert.ToInt32(Window.textpriority.Text);
            }
            try
            {
                Evdokimov_glazkiEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация обновлена");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            UpdateServices();
        }
    }
}
