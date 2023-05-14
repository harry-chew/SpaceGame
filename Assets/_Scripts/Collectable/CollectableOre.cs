using UnityEngine;

public class CollectableOre : MonoBehaviour, ICollectable
{
    [SerializeField] private int oreValue = 1;
    public void Collect(ShipStorage shipStorage)
    {
        // Add oreValue to player's ore count
        Debug.Log("CollectableOre.Collect() called: " + oreValue + " ore added to player's ore count");
        shipStorage.AddStorage(oreValue);
        Destroy(this.gameObject);
    }
}
