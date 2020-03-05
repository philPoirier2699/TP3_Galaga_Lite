using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class ShooterInputComponent : MonoBehaviour
{
    public InputAction shootInputAction;
    public UnityEvent onShoot;

    private bool isShooting = false;
    private void Awake()
    {
        shootInputAction.Enable();
        shootInputAction.started += _ => isShooting = true;
        shootInputAction.canceled += _ => isShooting = false;
    }
    void Update()
    {
        if (isShooting)
        {
            onShoot.Invoke();
        }
    }
}
