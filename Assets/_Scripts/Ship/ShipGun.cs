using System.Collections;
using UnityEngine;

public class ShipGun : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private float shootDelay = 0.5f;

    private bool canShoot = true;

    public void Fire()
    {
        canShoot = false;
        Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    }

    public IEnumerator FireWeapon(bool isShooting)
    {
        if(isShooting && canShoot)
        {
            Fire();
            yield return new WaitForSeconds(shootDelay);
            canShoot = true;
        }
    }
}
