using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweet : MonoBehaviour
{
    string system_tag_name = "System";
    string tweet_title = "reflectballfor1week";
    string tweet_tag_a = "unityroom";
    string tweet_tag_b = "unity1week";

    //スコアをツイートをするボタン用のイベント
    public void OnTweet(){
        GameObject[] score_data = GameObject.FindGameObjectsWithTag(system_tag_name);
        int totalscore = score_data[0].GetComponent<Scoreboard>().totals; 
        string tweet_text = "あなたはReflectBallで"+totalscore+"点スコアを取りました";
        naichilab.UnityRoomTweet.Tweet (tweet_title, tweet_text, tweet_tag_a, tweet_tag_b);
    }
}
