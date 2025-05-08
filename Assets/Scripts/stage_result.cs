using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//ステージ毎のスコアを表示するクラス
public class Stage_result : MonoBehaviour
{
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
        this.GetComponent<Text>().text = "ステージscore:" + system_object.GetComponent<Scoreboard>().score;
    }
}
