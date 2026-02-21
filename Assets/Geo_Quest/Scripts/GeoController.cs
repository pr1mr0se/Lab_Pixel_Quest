using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    int var = 3;
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
        Debug.Log(var);
        var++;
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);
        }

    }
}
