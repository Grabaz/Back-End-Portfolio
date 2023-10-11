using System.Windows;
namespace egzamin
{


    public partial class NameInputDialog : Window
    {
        public string EnteredName { get; private set; }

        public NameInputDialog()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            EnteredName = nameTextBox.Text;
            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}