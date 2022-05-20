using System.Windows;
using WPFGyak_Tabla.Models;

namespace WPFGyak_Tabla
{
    /// <summary>
    /// Interaction logic for SaveWindow.xaml
    /// </summary>
    public partial class SaveWindow : Window
    {
        public SaveWindow(Person person)
        {
            InitializeComponent();
            DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
