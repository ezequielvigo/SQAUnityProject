using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyGun : MonoBehaviour
{

    public float range = 100f;

    public NavMeshAgent agent;
    public ParticleSystem gunFlash;
    public GameObject hitEffect;
    public Player player;

    // Update is called once per frame
    void Update()
    {



    }

    public void Shoot(float damage)
    {
        gunFlash.Play();
        RaycastHit hitInfo;
        if (Physics.Raycast(agent.transform.position, agent.transform.forward, out hitInfo, range))
        {

            GameObject impact = Instantiate(hitEffect, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
            Destroy(impact, 1f);
        }

    }
}

