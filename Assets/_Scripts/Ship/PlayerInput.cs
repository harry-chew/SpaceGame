using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Vector2 inputVector;
    [SerializeField] private bool isShooting;

    public Action OnInventoryPressed;

    void Update()
    {
        inputVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxisRaw("Vertical"));

        if(Input.GetButtonDown("Fire1"))
            isShooting = true;
        else if (Input.GetButtonUp("Fire1"))
            isShooting = false;

        if (Input.GetKeyDown(KeyCode.I))
            OnInventoryPressed?.Invoke();
    }

    public bool GetIsShooting()
    {
        return isShooting;
    }

    public Vector2 GetMovementVector()
    {
        return inputVector;
    }
}
