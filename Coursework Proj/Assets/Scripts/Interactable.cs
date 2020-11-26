using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactable : MonoBehaviour
{
    public float range = 5f;

    public Camera fpsCam;
    public EnemiesLeft enemiesLeft;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Interact();
    }

    void Interact()
    {
        RaycastHit interacted;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out interacted, range))
        {
            if(interacted.transform.tag == "LevelEnd")
            {
                if (Input.GetKeyDown(KeyCode.E) && enemiesLeft.enemiesLeft == 0)
                {
                    SceneManager.LoadScene(1);
                }
            }
            Debug.Log(interacted.transform.name);

   
        }
    }
}
