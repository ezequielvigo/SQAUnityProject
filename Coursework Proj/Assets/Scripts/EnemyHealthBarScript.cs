using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBarScript : MonoBehaviour
{
    public Image healthBar;
    public EnemyController enemy;


    private void Update()
    {
        float amountToFill = enemy.amountToFill;
        healthBar.fillAmount = amountToFill;
    }
}
