using UnityEngine;

public class ShipThruster : MonoBehaviour
{
    [SerializeField] private float thrusterForce = 10f;
    [SerializeField] private GameObject thrusterSprite;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void AddThrust(Vector2 direction)
    {
        if (direction.y != 0)
        {
            rb.AddForce(transform.up * direction.y * thrusterForce);
            SetThrusterSprite(true);
        }
        else
        {
            SetThrusterSprite(false);
        }
    }

    public void SetThrusterSprite(bool isActive)
    {
        thrusterSprite.SetActive(isActive);
    }
}
