using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace egzamin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeDataBase();
        }

        private void Button_Click(object sender, RoutedEventArgs e) 
        {
            Window gameWindow = new Gra(this);
            gameWindow.Show();
            gameWindow.Focus();
            Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window bazaWindow = new baza(this);
            bazaWindow.Show();
            bazaWindow.Focus();
            Visibility = Visibility.Hidden;
        }

        private static void InitializeDataBase()
        {
            using (var context = new Kontekst())
            {
                context.Database.EnsureCreated();
                context.SaveChanges();
            }
        }
    }
}
