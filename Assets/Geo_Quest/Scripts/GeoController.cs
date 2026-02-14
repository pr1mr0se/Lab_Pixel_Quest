using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    string variableOne = "Hello";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        string variableTwo = "World";
        Debug.Log((variableOne + variableTwo));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
