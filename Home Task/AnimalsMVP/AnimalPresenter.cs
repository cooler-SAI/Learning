public class AnimalPresenter
{
    private readonly IAnimalView view;
    private readonly IAnimalRepository repository;

    public AnimalPresenter(IAnimalView view, IAnimalRepository repository)
    {
        this.view = view;
        this.repository = repository;
        this.view.SetPresenter(this);
    }

    public void AddAnimal(string name, int age, string type)
    {
        Animal animal = new Animal
        {
            Name = name,
            Age = age,
            Type = type
        };

        repository.AddAnimal(animal);
        view.AddAnimalToList(animal);
        view.ClearFields();
    }

    public void RemoveAnimal(Animal animal)
    {
        repository.RemoveAnimal(animal);
        view.RemoveAnimalFromList(animal);
    }

    public void UpdateAnimal(Animal animal)
    {
        repository.UpdateAnimal(animal);
        view.UpdateAnimalInList(animal);
    }
}
