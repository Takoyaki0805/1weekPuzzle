using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //refactored
    GameObject score_memory;
    public AudioSource audio_source;
    public AudioClip player_sound;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] system_object = GameObject.FindGameObjectsWithTag("System");
        score_memory = system_object[0]; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D collision){
        if(collision.gameObject.tag=="Player"){
            AudioSource.PlayClipAtPoint(player_sound,transform.position);
            score_memory.GetComponent<Scoreboard>().ScoreMemory(100);
            score_memory.GetComponent<Scoreboard>().PlusBonus(1);
            Destroy(this.gameObject);
        }
    }
}
