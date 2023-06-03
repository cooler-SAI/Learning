using System.Windows;
using System.Windows.Controls;

namespace AnimalApp
{
    public partial class MainWindow : Window, IAnimalView
    {
        private AnimalPresenter presenter;

        public MainWindow()
        {
            InitializeComponent();

            IAnimalRepository repository = new AnimalRepository();
            AnimalPresenter presenter = new AnimalPresenter(this, repository);
            SetPresenter(presenter);
        }



        public void SetPresenter(AnimalPresenter presenter)
        {
            this.presenter = presenter;
        }

        public void ClearFields()
        {
            nameTextBox.Text = "";
        }

        public void AddAnimalToList(Animal animal)
        {
            animalsListBox.Items.Add(animal);
        }

        public void RemoveAnimalFromList(Animal animal)
        {
            animalsListBox.Items.Remove(animal);
        }

        public void UpdateAnimalInList(Animal animal)
        {
            int index = animalsListBox.Items.IndexOf(animal);
            if (index != -1)
            {
                animalsListBox.Items[index] = animal;
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTextBox.Text;
            string? type = (typeComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Please enter both the name and type of the animal.");
                return;
            }

            //presenter.AddAnimal(name, type);
        }



        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            Animal? selectedAnimal = animalsListBox.SelectedItem as Animal;
            if (selectedAnimal != null)
            {
                presenter.RemoveAnimal(selectedAnimal);
            }
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            Animal? selectedAnimal = animalsListBox.SelectedItem as Animal;
            if (selectedAnimal != null)
            {
                string name = nameTextBox.Text;

                selectedAnimal.Name = name;

                presenter.UpdateAnimal(selectedAnimal);
            }
        }
    }
}
