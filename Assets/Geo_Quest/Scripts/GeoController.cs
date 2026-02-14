using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    string variableOne = "Hello";
  
    // Start is called before the first frame update
    void Start()
    {
        string variableTwo = "World";
        Debug.Log("Hello World");
        Debug.Log(variableOne + variableTwo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

