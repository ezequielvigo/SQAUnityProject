using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{

    public Player player;

    public float healthPickup = 40f;

    private void OnTriggerEnter(Collider collider)
    {
        if(player.currentHealth < player.maxHealth)
        {
            Destroy(gameObject);
            player.currentHealth += healthPickup;
            if(player.currentHealth > player.maxHealth)
            {
                player.currentHealth = 100f;
            }
        }
    }
}
