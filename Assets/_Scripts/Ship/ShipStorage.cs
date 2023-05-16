using System;
using System.Collections.Generic;
using UnityEngine;

public class ShipStorage : Subject
{
    public int maxStorage = 100;
    public int currentStorage = 0;

    [SerializeField] private List<InventoryItem> inventory = new List<InventoryItem>();

    public Action<List<InventoryItem>> OnStorageChanged;

    public void AddStorage(InventoryItem item)
    {
        Debug.Log("trying to add " + item.GetItemName());
        if (currentStorage + item.GetItemAmount() <= maxStorage)
        {
            currentStorage += item.GetItemAmount();
            inventory.Add(item);
            NotifyObservers();
            OnStorageChanged?.Invoke(inventory);
            Debug.Log("added: " + item.GetItemName());
        }
    }

    public void RemoveStorage(InventoryItem item)
    {
        currentStorage -= item.GetItemAmount();
        inventory.Remove(item);
        NotifyObservers();
        OnStorageChanged?.Invoke(inventory);
    }

    public List<InventoryItem> GetInventory()
    {
        return inventory;
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
