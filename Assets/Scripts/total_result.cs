using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Total_result : MonoBehaviour
{
    //refactored
    GameObject system_object;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] systems = GameObject.FindGameObjectsWithTag("System");   
        system_object = systems[0];
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Text>().text = "総score:" + system_object.GetComponent<Scoreboard>().totals;
    }
}
