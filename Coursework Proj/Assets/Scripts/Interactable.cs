using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Interactable : MonoBehaviour
{
    public float range = 5f;

    public Camera fpsCam;
    public EnemiesLeft enemiesLeft;
    public TextMeshProUGUI textShow;

    // Update is called once per frame
    void Update()
    {
        Interact();
    }

    //WHAT IS THIS DOING?
    void Interact()
    {
        textShow.enabled = false;
        RaycastHit interacted;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out interacted, range))
        {
            if(interacted.transform.tag == "LevelEnd")
            {
                textShow.enabled = true;
                if (Input.GetKeyDown(KeyCode.E) && enemiesLeft.enemiesLeft == 0)
                {
                    SceneManager.LoadScene(1);
                }
            }

   
        }
    }
}
