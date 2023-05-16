using UnityEngine;

public class InventoryItem
{
    [SerializeField] protected string itemName;
    [SerializeField] protected int itemAmount;

    public string GetItemName()
    {
        return itemName;
    }

    public int GetItemAmount()
    {
        return itemAmount;
    }
}
