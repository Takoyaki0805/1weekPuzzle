using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_summon : MonoBehaviour
{
    public GameObject[] player_summon;
    public GameObject player_object;
    public GameObject spawn_maker;
    Quaternion rotate_maker;
    GameObject score_memory;
    string system_tag_name  = "System";
    string player_tag_name  = "Player";
    int score_dec_point  = 10;
    float angle = 90f;
    // Start is called before the first frame update
    void Start()
    {
        //スコアを保持しているオブジェクトを探す
        GameObject[] system_object = GameObject.FindGameObjectsWithTag(system_tag_name);
        score_memory = system_object[0];
    }

    // Update is called once per frame
    void Update()
    {
        //スポーン地点に自機を回転をあわせて配置
        player_summon = GameObject.FindGameObjectsWithTag(player_tag_name);
        if(player_summon.Length == 0){
            rotate_maker = spawn_maker.transform.rotation;
            rotate_maker *= Quaternion.AngleAxis(angle,Vector3.forward);
            Instantiate(player_object,this.transform.position,rotate_maker);
            score_memory.GetComponent<Scoreboard>().DecScore(score_dec_point); 
        }
    }
}
