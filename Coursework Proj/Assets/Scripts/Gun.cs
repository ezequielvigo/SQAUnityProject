using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 150f;
    public float holdTime;

    public Camera fpsCam;
    public ParticleSystem gunFlash;
    public ParticleSystem loopingGunFlash;
    public GameObject hitEffect;

    void Update()
    {
        
        if (Input.GetButton("Fire1") || Input.GetButton("Fire2"))
        {
            if(Input.GetButton("Fire2"))
            {
                loopingGunFlash.Play();
            }
            holdTime += Time.deltaTime;
        }
        //Fire 2, charged gun fire (right mouse)
        if (Input.GetButtonUp("Fire2") && holdTime > 1f)
        {
            impactForce = impactForce * 5f;
            Shoot(damage * 2);
            loopingGunFlash.Stop();
            gunFlash.Play();
            holdTime = 0f;
            Debug.Log("Charged");

        }
        //IF HELD FOR LESS THAN 1 SEC NO SHOT/DAMAGE?
        else if (Input.GetButtonUp("Fire2") && holdTime < 1f)
        {
            loopingGunFlash.Stop();
            holdTime = 0f;
        }
        //Fire 1,semi automatic gun shot (left mouse)
        if (Input.GetButtonUp("Fire1") && holdTime < 1.5f)
        {
            gunFlash.Play();
            Shoot(damage);
            holdTime = 0f;
        }


    }

    //Applies damage to the enemy
    public void Shoot(float damage)
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hitInfo, range))
        {

            EnemyController enemy = hitInfo.transform.GetComponent<EnemyController>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            if(hitInfo.rigidbody != null)
            {
                hitInfo.rigidbody.AddForce(-hitInfo.normal * impactForce);
            }

            GameObject impact = Instantiate(hitEffect, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
            Destroy(impact, 1f);
        }
    }
}

