using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDHour7P2_PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health = 1004f;
        float poisonDamage = 125.5f;

        Debug.Log(health);

        while (health > 0)
        {
            health = health - poisonDamage;
            Debug.Log(health);
        }
        if (health <= 0)
        {
            Debug.Log("Player is dead!");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
