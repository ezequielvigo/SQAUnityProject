using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemiesLeftLevel1 : MonoBehaviour
{
    public int enemiesLeft = 16;
    public Canvas MainUI;
    public EnemyController enemy1;
    public EnemyController enemy2;
    public EnemyController enemy3;
    public EnemyController enemy4;
    public EnemyController enemy5;
    public EnemyController enemy6;
    public EnemyController enemy7;
    public EnemyController enemy8;
    public EnemyController enemy9;
    public EnemyController enemy10;
    public EnemyController enemy11;
    public EnemyController enemy12;
    public EnemyController enemy13;
    public EnemyController enemy14;
    public EnemyController enemy15;
    public EnemyController enemy16;

    private TextMeshProUGUI text;

    //First set of gates
    public GameObject gateClosed1;
    public GameObject gateOpened1;

    //Second set of gates
    public GameObject gateClosed2;
    public GameObject gateOpened2;

    //Third set of gates
    public GameObject gateClosed3;
    public GameObject gateOpened3;

    void Start()
    {
        text = MainUI.GetComponentInChildren<TextMeshProUGUI>();
        gateOpened1.SetActive(false);
        gateOpened2.SetActive(false);
        gateOpened3.SetActive(false);
    }

    void Update()
    {
        //updates remaining enemies each time an enemy is killed

        //Michael - 18 ELSE IFS NESTED IN THIS 1 IF STATEMENT. CAN WE MAKE THIS MORE CONCISE? 
        //Josh    - I had to resort to this as I couldn't figure out any other way to do it
        //          it certainly isn't efficient or good code, but it works. And we can talk about this
        //          in the report.
        if (enemy1.died)
        {
            enemiesLeft--;
            text.text = "Enemies Left: " + enemiesLeft;
            enemy1.died = false;
        }

        else if (enemy2.died)
        {
            enemiesLeft--;
            text.text = "Enemies Left: " + enemiesLeft;
            enemy2.died = false;
        }
        else if (enemy3.died)
        {
            enemiesLeft--;
            text.text = "Enemies Left: " + enemiesLeft;
            enemy3.died = false;
        }
        else if (enemy4.died)
        {
            enemiesLeft--;
            text.text = "Enemies Left: " + enemiesLeft;
            enemy4.died = false;
        }
        else if (enemy5.died)
        {
            enemiesLeft--;
            text.text = "Enemies Left: " + enemiesLeft;
            enemy5.died = false;
        }
        else if (enemy6.died)
        {
            enemiesLeft--;
            text.text = "Enemies Left: " + enemiesLeft;
            enemy6.died = false;
        }
        else if (enemy7.died)
        {
            enemiesLeft--;
            text.text = "Enemies Left: " + enemiesLeft;
            enemy7.died = false;
        }
        else if (enemy8.died)
        {
            enemiesLeft--;
            text.text = "Enemies Left: " + enemiesLeft;
            enemy8.died = false;
        }
        else if (enemy9.died)
        {
            enemiesLeft--;
            text.text = "Enemies Left: " + enemiesLeft;
            enemy9.died = false;
        }
        else if (enemy10.died)
        {
            enemiesLeft--;
            text.text = "Enemies Left: " + enemiesLeft;
            enemy10.died = false;
        }
        else if (enemy11.died)
        {
            enemiesLeft--;
            text.text = "Enemies Left: " + enemiesLeft;
            enemy11.died = false;
        }
        else if (enemy12.died)
        {
            enemiesLeft--;
            text.text = "Enemies Left: " + enemiesLeft;
            enemy12.died = false;
        }
        else if (enemy13.died)
        {
            enemiesLeft--;
            text.text = "Enemies Left: " + enemiesLeft;
            enemy13.died = false;
        }
        else if (enemy14.died)
        {
            enemiesLeft--;
            text.text = "Enemies Left: " + enemiesLeft;
            enemy14.died = false;
        }
        else if (enemy15.died)
        {
            enemiesLeft--;
            text.text = "Enemies Left: " + enemiesLeft;
            enemy15.died = false;
        }
        else if (enemy16.died)
        {
            enemiesLeft--;
            text.text = "Enemies Left: " + enemiesLeft;
            enemy16.died = false;
        }
        //MAYBE THIS NEXT BIT BECOMSE A NEW IF STATEMENT RATHER THAN BEING NESTED IN THE ABOVE (I TRIED IT AND IT WORKS FINE.)
        //opens gates when enemies are killed    
        else if (enemiesLeft == 14)
        {
            gateClosed1.SetActive(false);
            gateOpened1.SetActive(true);
        }
        else if (enemiesLeft == 8)
        {
            gateClosed2.SetActive(false);
            gateOpened2.SetActive(true);
        }
        else if(enemiesLeft == 0)
        {
            gateClosed3.SetActive(false);
            gateOpened3.SetActive(true);
        }
    }
}
