using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIY_2ImportantFunctions : MonoBehaviour
{
    public int runSpeed;
    // Start is called before the first frame update
    void Start()
    {
        print("start runs before an object updates");
    }

    // Update is called once per frame
    void Update()
    {
        print("This is called once a frame");
    }
}