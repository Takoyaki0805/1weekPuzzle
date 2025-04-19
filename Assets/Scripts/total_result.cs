using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tresult : MonoBehaviour
{
    //refactored
    GameObject single;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] gets = GameObject.FindGameObjectsWithTag("Sys");   
        single = gets[0];
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Text>().text = "総score:" + single.GetComponent<scoreboard>().totals;
    }
}
