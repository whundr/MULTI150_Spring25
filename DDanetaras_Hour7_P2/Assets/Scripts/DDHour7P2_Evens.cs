using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDHour7P2_Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        for (int count = 22; count <= 100; count++)
        {
            if (count % 2 == 0)
            {
                Debug.Log(count);
                count++;
            }
            else 
            {
                count++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
