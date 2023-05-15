using UnityEngine;

public class DamageableDebris : MonoBehaviour, IDamageable
{
    [SerializeField] private GameObject orePrefab;
    public void TakeDamage(float damage)
    {
        Instantiate(orePrefab, this.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
