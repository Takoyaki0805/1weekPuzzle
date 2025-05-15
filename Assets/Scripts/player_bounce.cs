using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_bounce : MonoBehaviour
{
    public int bounce_max = 5;
    int bounce_now = 0;
    public GameObject player_object;
    SpriteRenderer sprite_renderer;
    GameObject[] buttons;
    public AudioSource bounce_sound; 
    public AudioClip sound;
    string button_tag_name = "button";

    // Start is called before the first frame update
    void Start()
    {
        sprite_renderer = player_object.GetComponent<SpriteRenderer>();
        buttons = GameObject.FindGameObjectsWithTag(button_tag_name);
    }

    //地面に触れた場合反射回数が残っているなら反射する
    void OnCollisionEnter2D (Collision2D collision){
        if(bounce_now<=bounce_max){
            bounce_now++;
            float bounce_player_r = 1f;
            float bounce_player_g = 1f-(float)bounce_now/(float)bounce_max;
            float bounce_player_b = 1f-(float)bounce_now/(float)bounce_max;
            sprite_renderer.color = new Color(bounce_player_r,bounce_player_g,bounce_player_b);
            bounce_sound.PlayOneShot(sound);
        }else{
            foreach(GameObject b in buttons){
                b.SetActive(true);
            }
            Destroy(this.gameObject);
        }
    }
}
