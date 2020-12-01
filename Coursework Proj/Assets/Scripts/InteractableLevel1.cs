using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class InteractableLevel1 : MonoBehaviour
{
    public float range = 5f;

    public Camera fpsCam;
    public EnemiesLeftLevel1 enemiesLeft;
    public TMP_Text textShow;
    public int timesInteracted = 0;
    TMP_Text endText;

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
            if (interacted.transform.tag == "LevelEnd")
            {
                textShow.enabled = true;
                if (Input.GetKeyDown(KeyCode.E) && enemiesLeft.enemiesLeft == 0 && timesInteracted < 1)
                {
                    timesInteracted++;
                    Debug.Log(timesInteracted);
                    textShow.text = "You won! Well done! To restart the game interact with this again!";
                } else if (Input.GetKeyDown(KeyCode.E) && enemiesLeft.enemiesLeft == 0 && timesInteracted >= 1)
                {
                    SceneManager.LoadScene(0);
                }
            }


        }
    }
}
