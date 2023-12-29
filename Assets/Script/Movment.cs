using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Movment : MonoBehaviour

{
    [SerializeField] private Animator animator;
    public float moveSpeed = 400;
  
    private Vector2 inputValue;
    public Rigidbody2D playerRb;

    public void FixedUpdate()
    {
        playerRb.velocity= inputValue * moveSpeed* Time.deltaTime;
       
        animator.SetFloat("moveDirectionX",inputValue.x);
        animator.SetFloat("moveDirectionY",inputValue.y); 
        animator.SetFloat("moveSpeed",playerRb.velocity.magnitude);
    }

    public void Move(InputAction.CallbackContext context)
    {
        inputValue= context.ReadValue<Vector2>();
    }

 
}
