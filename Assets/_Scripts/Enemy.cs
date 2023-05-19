using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float collisionDamage;

    public float GetCollisionDamage()
    {
        return collisionDamage;
    }
}
