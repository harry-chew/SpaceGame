using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Vector2 inputVector;
    [SerializeField] private bool isShooting;

    void Update()
    {
        inputVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxisRaw("Vertical"));

        if(Input.GetButtonDown("Fire1"))
            isShooting = true;
        else if (Input.GetButtonUp("Fire1"))
            isShooting = false;
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
