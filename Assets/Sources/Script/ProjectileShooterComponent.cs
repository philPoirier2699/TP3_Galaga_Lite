using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooterComponent : MonoBehaviour
{
   // public GameObject projectileToShoot;
    public Transform exit;
    public float cooldown = 1;
    public ObjectPoolComponent projectileObjectPool;
    
    private float elapsedTime = 0;
    private void Update() => elapsedTime += Time.deltaTime;

    public void Shoot()
    {
        if (elapsedTime > cooldown)
        {
            var recycledProjectile = projectileObjectPool.GetObject();
            ResetProjectile(recycledProjectile);
            
            elapsedTime = 0;
        }
    }

    private void ResetProjectile(GameObject recycledProjectile)
    {
        recycledProjectile.transform.position = exit.position;
        recycledProjectile.transform.rotation = transform.rotation;
        recycledProjectile.SetActive(true);
    }
}
