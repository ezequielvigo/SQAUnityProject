using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBarScript : MonoBehaviour
{
    public Image healthBar;
    public float currentHealth;
    private float maxHealth = 100f;

    public Player player;

    private void Update()
    {
        //gets player health and displays it in healthbar
        currentHealth = player.currentHealth;
        healthBar.fillAmount = currentHealth / maxHealth;
    }
}