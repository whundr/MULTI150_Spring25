using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDHour7P2_MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int day = 1; day <= 31; day++) 
        {
            if (day == 8)
            {
                Debug.Log("It's My Birthday!");
                
            }
            else 
            {
                Debug.Log(day);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
