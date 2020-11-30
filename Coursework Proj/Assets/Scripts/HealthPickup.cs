using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{

    public Player player;

    public float healthPickup = 40f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
