using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public string fruit = "Apple";
    // Start is called before the first frame update
    void Start()
    {
        if (fruit == "Apple")
        {
            Debug.Log("I don't like apples");
        }
        else
        {
            Debug.Log($"The variable is {fruit}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
