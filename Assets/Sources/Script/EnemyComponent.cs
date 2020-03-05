using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyComponent : MonoBehaviour, IPoolable
{
    public ObjectPoolComponent AssociatedPool { get; set; }
   
    ProjectileShooterComponent PSC;
    private void Awake()
    {
        PSC = GetComponent<ProjectileShooterComponent>();
    }
    void Update()
    {
        if(transform.position.y < -8)
        {
            gameObject.SetActive(false);
            AssociatedPool.PutObject(gameObject);
            
        }
        PSC.Shoot();

    }
    void OnCollisionEnter(Collision collision)
    {
        
        if(collision.collider.gameObject.name == "EnnemiCapsule" || collision.collider.gameObject.name == "PlayerCapsule")
        {
            gameObject.SetActive(false);
            AssociatedPool.PutObject(gameObject);
        }
        if (collision.collider.gameObject.name == "PlayerShip" )
        {
            Time.timeScale = 0;
        }



    }
}
