using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int healthPoints = 3992;
    public int health = 400;
    
    void Start()
    {

        UsePotion(1);
        {
            Debug.Log(healthPoints);
        }
        UsePotion(1);
        {
            Debug.Log(healthPoints);
        }
        UsePotion(1);
        {
            Debug.Log(healthPoints);
        }
        UsePotion(1);
        {
            Debug.Log(healthPoints);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    int UsePotion(int health) {
        return healthPoints + health;
    }

}
