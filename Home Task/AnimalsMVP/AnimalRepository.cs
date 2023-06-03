using System.Collections.Generic;
using System.Linq;

public class AnimalRepository : IAnimalRepository
{
    private List<Animal> animals;

    public AnimalRepository()
    {
        animals = new List<Animal>();
    }

    public List<Animal> GetAnimals()
    {
        return animals;
    }

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void RemoveAnimal(Animal animal)
    {
        animals.Remove(animal);
    }

    public void UpdateAnimal(Animal animal)
    {        
        var existingAnimal = animals.FirstOrDefault(a => a.Name == animal.Name);
        if (existingAnimal != null)
        {
            existingAnimal.Age = animal.Age;
            existingAnimal.Type = animal.Type;
        }
    }
}
