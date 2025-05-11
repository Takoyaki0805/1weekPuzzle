using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//スコアを管理しているオブジェクトを探索しスコアをリセットするクラス
public class Score_reset : MonoBehaviour
{
    GameObject[] system;
    // Start is called before the first frame update
    void Start()
    {
        system = GameObject.FindGameObjectsWithTag("System");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreRemove(){
        system[0].GetComponent<Scoreboard>().ScoreReset();
    }
}
