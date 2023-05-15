using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithEnemies : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Enemy>(out Enemy enemy))
        {
            gameObject.GetComponent<ShipHealth>().TakeDamage(enemy.GetCollisionDamage());
        }
    }
}
