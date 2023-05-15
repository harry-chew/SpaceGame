using System.Collections;
using UnityEngine;

public class ShipHealth : Subject, IDamageable
{
    [SerializeField] private float maxHealth;
    private float currentHealth;

    private bool hasTakenDamage = true;
    private bool canRepair = true;
    [SerializeField] private float damageCooldown;
    [SerializeField] private float damageCooldownTimer;

    private void Start()
    {
        currentHealth = maxHealth / 10;
        damageCooldownTimer = damageCooldown;
    }

    private void Update()
    {
        if(hasTakenDamage)
        {
            StopAllCoroutines();
            //countdown from repair cooldown counter
            damageCooldownTimer -= Time.deltaTime;
        } else if(!hasTakenDamage && canRepair)
        {
            StartCoroutine(Repair());
        }

        if (damageCooldownTimer <= 0)
        {
            //reset cooldown counter
            damageCooldownTimer = damageCooldown;
            hasTakenDamage = false;
            canRepair = true;
        }
    }


    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        hasTakenDamage = true;
        damageCooldownTimer = damageCooldown;
        NotifyObservers();
    }

    public float GetCurrentHealth()
    {
        return currentHealth;
    }

    public float GetMaximumHealth()
    {
        return maxHealth;
    }

    public IEnumerator Repair()
    {
        canRepair = false;
        while (currentHealth < maxHealth)
        {
            currentHealth += 1f;
            NotifyObservers();
            yield return new WaitForSeconds(0.1f);
        }
    }
}
