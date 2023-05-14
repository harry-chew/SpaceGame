using UnityEngine;

public class FollowShip : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;

    private void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y, target.position.z) - offset;
    }
}
