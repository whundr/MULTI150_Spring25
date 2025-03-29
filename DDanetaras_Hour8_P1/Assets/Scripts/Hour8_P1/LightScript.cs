using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    void Start()
    {
        //target = GameObject Lightbulb;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
            Debug.Log("Lightbulb Brightness >= 1");
        else
            Debug.Log("Lightbulb Intensity < 1");
    }
}
