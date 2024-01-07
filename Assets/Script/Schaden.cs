using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class Schaden : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 30;
    public int hit = 10;
    [SerializeField]private  Canvas pause;
    void Start()
    {
        // der Game over screen wird unsichtbar gemacht 
        pause.enabled = false;
    }
    private void Awake()
    {
        // setzt die currentHealth auf 30
        currentHealth = maxHealth;
        
    }

   

    
   // Bei einer collision mit einem Objekt mt dem tag Enemy werden von den 30 10 abgezogen
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            currentHealth -= hit;
        }
    }

    public void Update()
    {
        // wenn die CurrentHealth unter 0 ist wird die zeit angehalten und der Game Over screen gezeigt 
        if (currentHealth<=0)
        {
            Time.timeScale = 0;
            if (Time.timeScale == 0)
            {
                pause.enabled = true;
            }
        }
    }
}
