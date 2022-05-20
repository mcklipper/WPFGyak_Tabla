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
            Person person = new();
            SaveWindow saveWindow = new SaveWindow(person);

            Hide();
            saveWindow.ShowDialog();
            Show();

            People.Add(person);
        }

        private void Edit_Button_Click(object sender, RoutedEventArgs e)
        {
            SaveWindow saveWindow = new SaveWindow((Person) dgPeople.SelectedItem);

            Hide();
            saveWindow.ShowDialog();
            Show();
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            People.Remove((Person) dgPeople.SelectedItem);
        }

    }
}
