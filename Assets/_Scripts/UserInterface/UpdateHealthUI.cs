using UnityEngine;

public class UpdateHealthUI : MonoBehaviour, IObserver
{
    [SerializeField] private ShipHealth shipHealth;
    private TMPro.TextMeshProUGUI healthText;
    
    void Start()
    {
        healthText = GetComponent<TMPro.TextMeshProUGUI>();
        shipHealth.AddObserver(this);
        healthText.text = "HP: " + shipHealth.GetCurrentHealth() + "/" + shipHealth.GetMaximumHealth();
    }

    public void UpdateObserver()
    {
        healthText.text = "HP: " + shipHealth.GetCurrentHealth() + "/" + shipHealth.GetMaximumHealth();
    }
}
