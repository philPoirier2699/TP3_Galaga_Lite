using System;
using UnityEngine;
using UnityEngine.Events;

public class DisableOverTimeComponent : MonoBehaviour
{
    public float timeBeforeDisable = 5;
    public Action onDisable;
    private float elapsedTime;
    
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > timeBeforeDisable || transform.position.y < -8 )
        {
            var objectToDisable = gameObject;
            onDisable.Invoke();
            objectToDisable.SetActive(false);
            elapsedTime = 0;
        }
    }
}
