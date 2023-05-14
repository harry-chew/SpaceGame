using UnityEngine;

public class ShipCollisions : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<ICollectable>(out ICollectable collectable))
        {
            collectable.Collect(gameObject.GetComponent<ShipStorage>());
        }
    }
}
