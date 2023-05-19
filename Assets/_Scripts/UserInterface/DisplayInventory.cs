using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInventory : MonoBehaviour
{
    [SerializeField] private ShipStorage shipStorage;
    [SerializeField] private GameObject inventoryButtonTemplate;
    [SerializeField] private Transform inventoryButtonParent;

    public List<Button> inventoryButtons = new List<Button>();

    [SerializeField] private int inventorySlots;
    private void Start()
    {
        shipStorage.OnStorageChanged += UpdateInventory;
        inventoryButtonParent = gameObject.transform;
        inventorySlots = shipStorage.GetInventorySlots();

        for (int i = 0; i < inventorySlots; i++)
        {
            GameObject inventoryButton = Instantiate(inventoryButtonTemplate, inventoryButtonParent);
            inventoryButton.SetActive(true);
            inventoryButtons.Add(inventoryButton.GetComponent<Button>());
        }

        inventoryButtonTemplate.SetActive(false);
    }

    private void OnEnable()
    {
        shipStorage.OnStorageChanged += UpdateInventory;

        UpdateInventory(shipStorage.GetInventory());
    }

    private void OnDestroy()
    {
        shipStorage.OnStorageChanged -= UpdateInventory;
    }

    private void UpdateInventory(List<InventoryItem> inventory)
    {
        foreach (InventoryItem item in inventory)
        {
            inventoryButtons[inventory.IndexOf(item)].GetComponentInChildren<Text>().text = item.GetItemName();
        }
    }
}