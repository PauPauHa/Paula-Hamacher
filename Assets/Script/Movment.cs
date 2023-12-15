using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movment : MonoBehaviour

{
    public float moveSpeed = 400;
    public float sprintMultiplier = 1;
    private Vector2 inputValue;
    public Rigidbody2D playerRb;

    public void FixedUpdate()
    {
        playerRb.velocity= inputValue * moveSpeed * sprintMultiplier * Time.deltaTime;
       
    }

    public void Move(InputAction.CallbackContext context)
    {
        inputValue= context.ReadValue<Vector2>();
    }

 
}