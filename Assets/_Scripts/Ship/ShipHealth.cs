using UnityEngine;

public class ShipHealth : Subject, IDamageable
{
    [SerializeField] private int maxHealth;
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }
    
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

    public int GetCurrentHealth()
    {
        Debug.Log(currentHealth);
        return currentHealth;
    }

    public int GetMaximumHealth()
    {
        Debug.Log(maxHealth);
        return maxHealth;
    }
}
