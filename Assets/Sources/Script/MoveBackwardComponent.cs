using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackwardComponent : MonoBehaviour
{
    public float force = 1;
    void Update()
    {
        transform.Translate(Vector3.up * (force * Time.deltaTime), Space.Self);
    }
}
