using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//合計のスコアをテキストに表記するクラス
public class Total_result : MonoBehaviour
{
    //refactored
    GameObject system_object;
    string system_tag = "System";
    string text_param = "総score:";
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] systems = GameObject.FindGameObjectsWithTag(system_tag);   
        system_object = systems[0];
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Text>().text = text_param + system_object.GetComponent<Scoreboard>().totals;
    }
}
