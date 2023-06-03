using System.Collections.Generic;

public interface IAnimalRepository
{
    List<Animal> GetAnimals();
    void AddAnimal(Animal animal);
    void RemoveAnimal(Animal animal);
    void UpdateAnimal(Animal animal);
}
