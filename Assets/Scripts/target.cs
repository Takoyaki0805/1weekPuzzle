using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    //refactored
    GameObject score_mem;
    public AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] tmp = GameObject.FindGameObjectsWithTag("System");
        score_mem = tmp[0]; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D collision){
        if(collision.gameObject.tag=="Player"){
            AudioSource.PlayClipAtPoint(se,transform.position);
            score_mem.GetComponent<scoreboard>().score_memory(100);
            score_mem.GetComponent<scoreboard>().plusbonus(1);
            Destroy(this.gameObject);
        }
    }
}
