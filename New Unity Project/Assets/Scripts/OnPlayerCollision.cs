using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlayerCollision : MonoBehaviour{
    public static OnPlayerCollision instance;
    public bool IsPlayerDead;
    public float timer;

    void Start()
    {
        instance = this;

    }

    void Update()
    {

    }


}

