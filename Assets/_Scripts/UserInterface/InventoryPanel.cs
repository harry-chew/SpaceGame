using UnityEngine;

public class InventoryPanel : MonoBehaviour
{
    [SerializeField] private GameObject inventoryPanel;
    [SerializeField] private PlayerInput playerInput;

    private void OnEnable()
    {
        playerInput.OnInventoryPressed += ToggleInventory;
    }


    private void OnDisable()
    {
        playerInput.OnInventoryPressed -= ToggleInventory;
    }

    private void ToggleInventory()
    {
        if(inventoryPanel.activeSelf)
        {
            inventoryPanel.SetActive(false);
        }
        else
        {
            inventoryPanel.SetActive(true);
        }
    }
}
