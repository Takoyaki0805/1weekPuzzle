using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tweet : MonoBehaviour
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

    public void ontweet(){
        GameObject[] get = GameObject.FindGameObjectsWithTag("System");
        int totalscore = get[0].GetComponent<scoreboard>().totals; 
        naichilab.UnityRoomTweet.Tweet ("reflectballfor1week", "あなたはReflectBallで"+totalscore+"点スコアを取りました", "unityroom", "unity1week");
    }
}
