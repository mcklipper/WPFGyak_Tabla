using System.Windows;
using WPFGyak_Tabla.Models;

namespace WPFGyak_Tabla
{
    /// <summary>
    /// Interaction logic for CreatePersonWindow.xaml
    /// </summary>
    public partial class CreatePersonWindow : Window
    {
        private Person person;

        public CreatePersonWindow(Person person)
        {
            InitializeComponent();
            DataContext = person;
            this.person = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
