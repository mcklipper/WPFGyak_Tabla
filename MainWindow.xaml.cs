using System.Collections.ObjectModel;
using System.Windows;
using WPFGyak_Tabla.Models;

namespace WPFGyak_Tabla
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> People { get; init; }

        public MainWindow()
        {
            People = new()
            {
                new Person("Patrik", "Egri", new(1999, 12, 28), 170, 78),
                new Person("Balázs", "Farkas", new(1997, 8, 17), 175, 75),
                new Person("Dóra", "Balogh", new(1995, 4, 15), 163, 68),
            };

            InitializeComponent();
        }

        private void Create_Button_Click(object sender, RoutedEventArgs e)
        {
            Person newPerson = new Person();
            CreatePersonWindow window = new(newPerson);
            
            window.ShowDialog();
            People.Add(newPerson);
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            Person? selectedPerson = dgPeople.SelectedItem as Person;

            if (selectedPerson != null)
                People.Remove(selectedPerson);
        }

        private void Edit_Button_Click(object sender, RoutedEventArgs e)
        {
            Person? selectedPerson = dgPeople.SelectedItem as Person;

            if (selectedPerson == null) return;

            CreatePersonWindow window = new(selectedPerson);
            window.ShowDialog();
        }
    }
}
