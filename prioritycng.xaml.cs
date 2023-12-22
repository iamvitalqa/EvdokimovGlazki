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

namespace EvdokimovGlazki
{
    /// <summary>
    /// Логика взаимодействия для prioritycng.xaml
    /// </summary>
    public partial class prioritycng : Window
    {
        public prioritycng(int max)
        {
            InitializeComponent();
            textpriority.Text = max.ToString();
        }

        private void SaveBTN_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(textpriority.Text))
                errors.AppendLine("Укажите приоритет для агентов");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void CloseBTN_Click(object sender, RoutedEventArgs e)
        {
            textpriority.Text = "";
            Close();
        }
    }
}
