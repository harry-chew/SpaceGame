using UnityEngine;

public class UpdateOreUI : MonoBehaviour, IObserver
{
    private TMPro.TextMeshProUGUI oreText;
    [SerializeField] private ShipStorage shipStorage;

    public void UpdateObserver()
    {
        oreText.text = "Ore: " + shipStorage.GetStorage() + "/" + shipStorage.GetMaxStorage();
    }

    private void Start()
    {
        oreText = GetComponent<TMPro.TextMeshProUGUI>();
        shipStorage.AddObserver(this);
        oreText.text = "Ore: " + shipStorage.GetStorage() + "/" + shipStorage.GetMaxStorage();
    }
}
