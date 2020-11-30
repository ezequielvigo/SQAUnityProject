using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBarScript : MonoBehaviour
{
    public Image healthBar;
    public EnemyController enemy;

    //Update is called once per frame
    private void Update()
    {
        float amountToFill = enemy.amountToFill;
        healthBar.fillAmount = amountToFill;
    }
}
