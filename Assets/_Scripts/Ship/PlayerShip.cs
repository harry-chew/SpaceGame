using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private ShipThruster shipThruster;
    [SerializeField] private ShipGyroscope shipGyroscope;
    [SerializeField] private ShipGun shipGun;
    [SerializeField] private ShipStorage shipStorage;

    private void Update()
    {
        StartCoroutine(shipGun.FireWeapon(playerInput.GetIsShooting()));
    }

    private void FixedUpdate()
    {
        float deltaTime = Time.deltaTime;
        shipThruster.AddThrust(playerInput.GetMovementVector() * deltaTime);
        shipGyroscope.AddGyroscope(playerInput.GetMovementVector() * deltaTime);
    }
}
