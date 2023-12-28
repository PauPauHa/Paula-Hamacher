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
        pause.enabled = false;
    }
    private void Awake()
    {
        currentHealth = maxHealth;
    }

   

    

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            currentHealth -= hit;
        }
    }

    public void Update()
    {
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
