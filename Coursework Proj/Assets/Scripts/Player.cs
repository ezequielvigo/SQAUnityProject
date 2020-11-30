
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public int scene1;
    public int scene2;


    //Called before the first frame update, thus full health
    void Start()
    {
        currentHealth = maxHealth;
        Debug.Log(SceneManager.GetActiveScene().ToString() + " ge");
    }


    //updates players current health
    public void TakeDamage(float damage)

    {
        currentHealth -= damage;
        if(currentHealth < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
