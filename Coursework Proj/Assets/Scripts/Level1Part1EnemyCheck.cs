using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level1Part1EnemyCheck : MonoBehaviour
{
    public int enemiesLeft = 3;
    public EnemyController enemy1;
    public EnemyController enemy2;
    public EnemyController enemy3;
    public GameObject gateClosed;
    public GameObject gateOpened;

    void Start()
    {
        gateOpened.SetActive(false);
    }

    void Update()
    {//updates remaining enemies each time an enemy is killed
        if (enemy1.died && enemy2.died && enemy3.died)
        {
            gateClosed.SetActive(false);
            gateOpened.SetActive(true);

        }
    }
}
