using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemiesLeftLevel1 : MonoBehaviour
{
    public int enemiesLeft = 5;
    public Canvas MainUI;
    public EnemyController enemy1;
    public EnemyController enemy2;
    public EnemyController enemy3;
    public EnemyController enemy4;
    public EnemyController enemy5;
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
    {//updates remaining enemies each time an enemy is killed
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
        else if (enemiesLeft == 3)
        {
            gateClosed1.SetActive(false);
            gateOpened1.SetActive(true);
        }
        else if(enemiesLeft == 0)
        {
            gateClosed2.SetActive(false);
            gateOpened2.SetActive(true);
        }
    }
}
