using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    [SerializeField] private ShipStorage shipStorage;
    private void OnEnable()
    {
        shipStorage.OnStorageChanged += UpdateInventory;
    }

    private void OnDisable()
    {
        shipStorage.OnStorageChanged -= UpdateInventory;
    }

    private void UpdateInventory(List<InventoryItem> inventory)
    {
        foreach (InventoryItem item in inventory)
        {
            Debug.Log(item.GetItemName());
        }
    }
}