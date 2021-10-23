using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityBehavior : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            Debug.Log("hit by enemy");
            TakeDamage(50);
        }

        if(collision.gameObject.tag == "projectile")
        {
            Debug.Log("hit by projectile");
            TakeDamage(25);
        }

        if (collision.gameObject.tag == "kamikaze")
        {
            Debug.Log("Hit by Kamikaze");
            TakeDamage(100);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
