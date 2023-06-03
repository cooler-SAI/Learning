public interface IAnimalView
{
    void SetPresenter(AnimalPresenter presenter);
    void ClearFields();
    void AddAnimalToList(Animal animal);
    void RemoveAnimalFromList(Animal animal);
    void UpdateAnimalInList(Animal animal);
}
