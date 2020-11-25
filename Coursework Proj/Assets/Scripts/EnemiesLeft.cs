using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemiesLeft : MonoBehaviour
{
    int enemiesLeft = 0;
    bool killedAll = false;
    TextMeshProUGUI instruction;
    Target[] enemies;
    Target enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindObjectOfType<Target>();
        enemies = GameObject.FindObjectsOfType<Target>();
        Debug.Log(enemies);
        instruction = GameObject.Find("Text (TMP)").GetComponent<TextMeshProUGUI>();
        enemiesLeft = 2;
    }

    // Update is called once per frame
    void Update()
    {
        enemiesLeft = enemies.Length;
        if (enemy.died)
        {
            enemiesLeft--;
            instruction.text = "Enemies Left: " + enemiesLeft;
        }
    }
}
