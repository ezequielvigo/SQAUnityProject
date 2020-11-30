using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    public float lookRadius = 10f;
    public float health = 75f;
    public bool died = false;
    public float amountToFill = 1f;
    public float amountToSubtract;

    public Transform player;
    public NavMeshAgent agent;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("First-Person Player").transform;
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);

        if(distance <= lookRadius)
        {
            agent.SetDestination(player.position);
        }
    }

    public void TakeDamage(float damage)
    {
        amountToSubtract = (damage / health);//If hp is 50 and dmg is 10, amountToSubtract is .2 = 20% dmg (DOES THIS MEAN DAMAGE RECIEVED IS DEPENDANT ON CURRENT HELTH?)
        amountToFill -= amountToSubtract;
        health -= damage;

        if (health <= 0f)
        {
            died = true;
            Die();

        }
    }

    void Die()
    {
        died = true;
        gameObject.SetActive(false);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
