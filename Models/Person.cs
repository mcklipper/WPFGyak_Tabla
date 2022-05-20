using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFGyak_Tabla.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string firstname;
        private string lastname;
        private DateTime dateOfBirth;
        private int height;
        private float weight;
        private PersonType personType;

        public Person()
        {
            Id = Guid.NewGuid();
        }

        public Person
        (
            string firstname,
            string lastname,
            DateTime dateOfBirth,
            int height,
            float weight
        )
        {
            Id = Guid.NewGuid();
            Firstname = firstname;
            Lastname = lastname;
            DateOfBirth = dateOfBirth;
            Height = height;
            Weight = weight;
        }

        public Guid Id { get; set; }
        public string Firstname 
        { 
            get => firstname; 
            set { firstname = value; OnPropertyChanged(nameof(Fullname)); }
        }

        public string Lastname 
        { 
            get => lastname; 
            set {lastname = value; OnPropertyChanged(nameof(Fullname)); }
        }

        public DateTime DateOfBirth 
        { 
            get => dateOfBirth; 
            set {dateOfBirth = value; OnPropertyChanged(nameof(DateOfBirth)); }
        }

        public int Height 
        { 
            get => height; 
            set {height = value; OnPropertyChanged(nameof(Height)); }
        }

        public float Weight 
        { 
            get => weight; 
            set {weight = value; OnPropertyChanged(nameof(Weight)); }
        }

        public PersonType PersonType
        {
            get => personType;
            set { personType = value; OnPropertyChanged(nameof(PersonTypeStr)); }
        }

        public string Fullname => $"{ Lastname } { Firstname }";

        public string PersonTypeStr =>
            (PersonType == PersonType.TermeszetesSzemely)
            ? "Természetes személy"
            : "Jogi személy";

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new(propertyName));
        }
    }
}
