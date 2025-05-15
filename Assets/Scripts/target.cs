using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    GameObject score_memory;
    public AudioSource audio_source;
    public AudioClip player_sound;
    string system_tag = "System";
    string player_tag_name = "Player";
    int score_point = 100;
    int bonus_point = 1;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] system_object = GameObject.FindGameObjectsWithTag(system_tag);
        score_memory = system_object[0]; 
    }

    //ターゲットにあたったときの動作
    void OnTriggerEnter2D (Collider2D collision){
        if(collision.gameObject.tag == player_tag_name){
            //効果音を再生(ターゲットが消えるのでPlayClipAtPount)
            AudioSource.PlayClipAtPoint(player_sound,transform.position);
            score_memory.GetComponent<Scoreboard>().ScoreMemory(score_point);
            score_memory.GetComponent<Scoreboard>().PlusBonus(bonus_point);
            Destroy(this.gameObject);
        }
    }
}
