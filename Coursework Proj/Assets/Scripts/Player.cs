using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    //Called before the first frame update, thus full health
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }
    //updates players current health
    public void TakeDamage(float damage)

    {
        currentHealth -= damage;
    }

}
