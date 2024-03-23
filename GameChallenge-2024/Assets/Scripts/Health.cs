using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float startingHealth = 3;
    private float currentHealth;

    void Start()
    {
        currentHealth = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(float damage)
    {
        currentHealth  = Mathf.Clamp(currentHealth - damage, 0, startingHealth);
        if (currentHealth > 0)
        {
            // Play hurt animation
        }
        else
        {
            Die();
        }
    }

    void Die()
    {

    }

    public float getCurrentHealth()
    {
        return currentHealth;
    }
}
