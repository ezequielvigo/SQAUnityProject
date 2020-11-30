using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public bool died = false;

    //Applies damage to enemy and renders them dead
    public void TakeDamage(float damage)
    {
        health -= damage;
        if(health <= 0f)
        {
            Die();

        }
    }

    //once enemy is "dead", they're destroyed
    void Die()
    {
        died = true;
        Destroy(gameObject);
    }
}
