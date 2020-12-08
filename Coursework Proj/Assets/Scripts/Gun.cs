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
        //Michael - IF HELD FOR LESS THAN 1 SEC NO SHOT/DAMAGE?
        //Josh    - Yes, no shot or damage
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
    //Michael - IS IT INTENTIONAL THAT THE SHOT HAS TO BE DEAD CENTER ON THE ENEMY? DOESN'T TAKE DAMAGE IF NOT, 
    //          CANT SEE WHERE THIS IS THOUGH. I IMAGINE ITS PART OF THE "hitinfo" 
    //Josh    - It does not need to be dead center on the enemy:
    //          The Raycast determines what the player is looking at, so if they are aiming at the enemy's collider object
    //          and shoot, the enemy will take damage
    //        - I will admit that the collider isn't perfect, the lack of graphics for the enmy does make 
    //          it more confusing for the player to know if they have hit the enemy for sure
    //        - The Raycast determines what the player is looking at, so if they are aiming at the enemy and shoot
    //          the enemy will take damage


    //UPDATE
    //Josh    - In response to your complaint I definitely noticed how bad the collider for the enemy was wrt. hitting the enemy
    //        - Significantly changed the collider for the enemy, it is now much easier to hit the enemy reliably
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

