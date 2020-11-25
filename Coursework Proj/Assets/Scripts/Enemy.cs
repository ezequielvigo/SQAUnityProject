using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    #region Singleton

    public static Enemy instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject enemy;

}
