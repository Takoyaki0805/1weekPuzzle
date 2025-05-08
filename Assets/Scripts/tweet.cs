using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweet : MonoBehaviour
{
    //refactored
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTweet(){
        GameObject[] score_data = GameObject.FindGameObjectsWithTag("System");
        int totalscore = score_data[0].GetComponent<Scoreboard>().totals; 
        naichilab.UnityRoomTweet.Tweet ("reflectballfor1week", "あなたはReflectBallで"+totalscore+"点スコアを取りました", "unityroom", "unity1week");
    }
}
