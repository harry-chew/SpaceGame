using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float projectileSpeed = 10f;
    [SerializeField] private float projectileLifetime = 5f;
    
    private void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = transform.up * projectileSpeed;
        Destroy(this.gameObject, projectileLifetime);
    }
}
