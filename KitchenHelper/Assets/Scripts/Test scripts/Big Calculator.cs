using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCalculator : MonoBehaviour
{
    

    List<int> Numbers;
    // Start is called before the first frame update
    void Start()
    {
        Numbers = new List<int>(10);
        Numbers.Add(00);
        Numbers.Add(10);
        Numbers.Add(20);
        Numbers.Add(30);
        Numbers.Add(40);
        Numbers.Add(50);
        Numbers.Add(60);
        Numbers.Add(70);
        Numbers.Add(80);
        Numbers.Add(90);
        Numbers.Add(100);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("HIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII");
            Debug.Log(Numbers[0]);
        }
    }
}
