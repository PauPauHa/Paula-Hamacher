using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class EnemySchaden : MonoBehaviour
{
     [SerializeField] GameObject partical;
    
    public int currentHealth;
    public int maxHealth = 30;
    public int hit = 10;

    private void Awake()
    {
        // currentHealth =30
        currentHealth = maxHealth;
     
     
    }

    // wenn er mit etwas collidiert das den Tag Bullet hat kriegt er Schaden und die Methode SpwanSplash wird aufgerufen
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            currentHealth -= hit;
            SpawnSplash();
        }
    }
 // ist die currenthealth unter 0 wird der enemy zerstört
    private void Update()
    {
        if(currentHealth <= 0)
        {
          Destroy(gameObject);  
          
        }
       
    }

    private void SpawnSplash()
    //erzäugt das partical System was dann bei einer collision ausgelöst wird weil die Methode aufgerufen wurde 
    {
        Instantiate(partical, transform.position, Quaternion.identity);
    }
}
