using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBarScript : MonoBehaviour
{
    private Image healthBar;

    public GameObject worldUI;
    public float currentHealth;
    private float maxHealth = 75f;

    Target[] enemy;

    private void Start()
    {
        enemy = FindObjectsOfType<Target>();
        healthBar = GetComponent<Image>();

    }

    private void Update()
    {
        if (enemy[0])
        {
            currentHealth = enemy[0].health;
            healthBar.fillAmount = currentHealth / maxHealth;
        }
        else if (enemy[1])
        {
            currentHealth = enemy[1].health;
            healthBar.fillAmount = currentHealth / maxHealth;
        }
        else if (enemy[2])
        {
            currentHealth = enemy[2].health;
            healthBar.fillAmount = currentHealth / maxHealth;
        }
    }
}
