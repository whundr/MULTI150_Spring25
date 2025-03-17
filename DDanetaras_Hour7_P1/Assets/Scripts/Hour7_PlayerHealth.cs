using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hour7_PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health = 1004f;
        float poisonDamage = 125.5f;

        Debug.Log(health);

        health = health - poisonDamage;
        Debug.Log(health);

        health = health - poisonDamage;
        Debug.Log(health);

        health = health - poisonDamage;
        Debug.Log(health);

        health = health - poisonDamage;
        Debug.Log(health);

        health = health - poisonDamage;
        Debug.Log(health);

        health = health - poisonDamage;
        Debug.Log(health);

        health = health - poisonDamage;
        Debug.Log(health);

        health = health - poisonDamage;
        Debug.Log(health);

        Debug.Log("Player is Dead!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
