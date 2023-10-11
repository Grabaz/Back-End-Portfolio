using Microsoft.EntityFrameworkCore;
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

namespace egzamin
{

    public partial class baza : Window
    {
        private Window mainWindow;
        public baza(Window window = null)
        {
            mainWindow = window;
            InitializeComponent();
            Focus();

            using (var dbContext = new Kontekst())
            {
                var users = dbContext.Rekord.ToList();
                recordsDataGrid.ItemsSource = users;
            }
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Focus();
            mainWindow.Visibility = Visibility.Visible;
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainWindow.Focus();
            mainWindow.Visibility = Visibility.Visible;
        }
    }
}
