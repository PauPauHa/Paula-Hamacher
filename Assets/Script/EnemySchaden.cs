using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class EnemySchaden : MonoBehaviour
{
    
    
    public int currentHealth;
    public int maxHealth = 30;
    public int hit = 10;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            currentHealth -= hit;
        }
    }

    private void Update()
    {
        if(currentHealth <= 0)
        {
          Destroy(gameObject);  
        }
    }
}
