using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class MoveInputComponent : MonoBehaviour
{
    public InputAction moveY;
    public InputAction moveX;
    Vector2 translation;
    public float maxSpeed = 22;
    public bool isMovingX = false;
    public bool isMovingY = false;
    float limitsX = 11.3f;
    float limitsY = 6.4f;
    private void Awake()
    {
        moveY.Enable();
        moveY.started += _ => isMovingY = true;
        moveY.canceled += _ => isMovingY = false;
        moveX.Enable();
        moveX.started += _ => isMovingX = true;
        moveX.canceled += _ => isMovingX = false;
    }
    void Update()
    {
        if (isMovingX || isMovingY )
        {
            Vector2 delta = new Vector2(moveX.ReadValue<float>(), moveY.ReadValue<float>());
            translation = delta.normalized * Time.deltaTime * maxSpeed;

            if ((transform.position.x + translation.x) < limitsX && (transform.position.x + translation.x) > -limitsX
                && (transform.position.y + translation.y) < limitsY && (transform.position.y + translation.y) > -limitsY)
            transform.Translate(translation);
        }
    }
}