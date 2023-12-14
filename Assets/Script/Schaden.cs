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
    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage()
    {
        if (CompareTag("Enemy"))
        {
            currentHealth -= hit;
        }
       
    }

    public void Update()
    {
        if (currentHealth<=0)
        {
            Object.Destroy(gameObject, 0);
        }
    }
}
