using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_bounce : MonoBehaviour
{
    //refactored
    public int bounce_max = 5;
    int bounce_now = 0;
    public GameObject player_object;
    SpriteRenderer SpriteRenderer;
    GameObject[] buttons;
    public AudioSource bounce_sound; 
    public AudioClip se;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer = player_object.GetComponent<SpriteRenderer>();
        buttons = GameObject.FindGameObjectsWithTag("button");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D (Collision2D collision){

        if(bounce_now<=bounce_max){
            bounce_now++;
            SpriteRenderer.color = new Color(1f,1f-(float)bounce_now/(float)bounce_max,1f-(float)bounce_now/(float)bounce_max);
            Debug.Log(1f-(float)bounce_now/(float)bounce_max);
            bounce_sound.PlayOneShot(se);
        }else{
            foreach(GameObject b in buttons){
                b.SetActive(true);
            }
            Destroy(this.gameObject);
        }
    }
}
