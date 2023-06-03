using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace AnimalApp
{
    public partial class MainWindow : Window
    {
        private List<Animal> animals;

        public MainWindow()
        {
            InitializeComponent();
            animals = new List<Animal>();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string animalType = ((ComboBoxItem)animalTypeComboBox.SelectedItem).Content.ToString();
            string name = nameTextBox.Text;

            Animal animal = AnimalFactory.CreateAnimal(animalType, name);
            if (animal != null)
            {
                animals.Add(animal);
                MessageBox.Show($"Added a new {animalType}: {name}");
            }
            else
            {
                MessageBox.Show("Unknown animal type.");
            }
        }

        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            if (animals.Count > 0)
            {
                foreach (Animal animal in animals)
                {
                    animal.DisplayInfo();
                }
            }
            else
            {
                MessageBox.Show("No animals to display.");
            }
        }
    }

    public abstract class Animal
    {
        public string Name { get; }
        public string Species { get; }

        public Animal(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public virtual void DisplayInfo()
        {
            MessageBox.Show($"Name: {Name}\nSpecies: {Species}");
        }
    }

    public class Mammal : Animal
    {
        public Mammal(string name) : base(name, "Mammal")
        {
        }
    }

    public class Bird : Animal
    {
        public Bird(string name) : base(name, "Bird")
        {
        }
    }

    public class Amphibian : Animal
    {
        public Amphibian(string name) : base(name, "Amphibian")
        {
        }
    }

    public static class AnimalFactory
    {
        public static Animal CreateAnimal(string animalType, string name)
        {
            switch (animalType)
            {
                case "Mammal":
                    return new Mammal(name);
                case "Bird":
                    return new Bird(name);
                case "Amphibian":
                    return new Amphibian(name);
                default:
                    return null;
            }
        }
    }
}
