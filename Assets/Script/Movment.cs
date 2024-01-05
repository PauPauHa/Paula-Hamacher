using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;


public class Movment : MonoBehaviour

{
    [SerializeField] private Animator animator;
    public float moveSpeed = 400;
  
    private Vector2 inputValue;
    public Vector2 mousePos;
    public Rigidbody2D playerRb;
    public Camera cam;

    public void Update()
    {
        mousePos=cam.ScreenToWorldPoint(Input.mousePosition);
    }

    public void FixedUpdate()
    {
        playerRb.velocity= inputValue * moveSpeed* Time.deltaTime;
       
        animator.SetFloat("moveDirectionX",inputValue.x);
        animator.SetFloat("moveDirectionY",inputValue.y); 
        animator.SetFloat("moveSpeed",playerRb.velocity.magnitude);
        
        Vector2 lookDir= mousePos-playerRb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        playerRb.rotation = angle;
    }

    public void Move(InputAction.CallbackContext context)
    {
        inputValue= context.ReadValue<Vector2>();
    }

 
}
