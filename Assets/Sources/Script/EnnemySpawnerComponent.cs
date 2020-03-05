using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemySpawnerComponent : MonoBehaviour
{
    public ObjectPoolComponent ennemyPool;
    public float timeBetweenSpawns = 5;

    private System.Random rando = new System.Random();
    
    private float elapsed = 0;

    void Update()
    {
        elapsed += Time.deltaTime;
        if(elapsed > timeBetweenSpawns)
        {
            Spawn();
            elapsed = 0;
        }
    }
    public void Spawn()
    {
        Vector3 aleatoire = new Vector3(rando.Next(-10, 10), 0,0 );
        GameObject recycledEnnemy = ennemyPool.GetObject();
        recycledEnnemy.transform.position = transform.position + aleatoire;
        recycledEnnemy.transform.rotation = transform.rotation;
        recycledEnnemy.SetActive(true);
    }
}
