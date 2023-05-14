public class ShipStorage : Subject
{
    public int maxStorage = 100;
    public int currentStorage = 0;

    public void AddStorage(int amount)
    {
        currentStorage += amount;
        NotifyObservers();
    }

    public void RemoveStorage(int amount)
    {
        currentStorage -= amount;
        NotifyObservers();
    }

    public bool HasStorage(int amount)
    {
        return currentStorage >= amount;
    }

    public int GetStorage()
    {
        return currentStorage;
    }

    public int GetMaxStorage()
    {
        return maxStorage;
    }
}
