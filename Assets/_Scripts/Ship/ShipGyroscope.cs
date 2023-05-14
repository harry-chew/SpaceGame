using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipGyroscope : MonoBehaviour
{
    [SerializeField] private float gyroscopeForce = 10f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void AddGyroscope(Vector2 direction)
    {
        if (direction.x != 0)
        {
            rb.AddTorque(-direction.x * gyroscopeForce);
        }
    }
}
