using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemiesLeft : MonoBehaviour
{
    public int enemiesLeft = 3;
    public Canvas MainUI;
    public EnemyController enemy1;
    public EnemyController enemy2;
    public EnemyController enemy3;
    private TextMeshProUGUI text;


    void Start()
    {
        text = MainUI.GetComponentInChildren<TextMeshProUGUI>();
    }

    void Update()
    {//updates remaining enemies each time an enemy is killed
        if (enemy1.died)
        {
            enemiesLeft--;
            text.text = "Enemies Left: " + enemiesLeft;
            enemy1.died = false;
        } else if(enemy2.died)
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

    }
}
