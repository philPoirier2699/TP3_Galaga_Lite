using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComponent : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.gameObject.name == "EnnemiCapsule")
        {
            Debug.Log(collision.collider.gameObject.name);
        }
        
       
    }
}
