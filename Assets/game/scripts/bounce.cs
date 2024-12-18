using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    public int bounceMax = 5;
    int bounceNow = 0;
    public GameObject uho;
    SpriteRenderer SpriteRenderer;
    GameObject[] bus;
    public AudioSource bou; 
    public AudioClip se;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer = uho.GetComponent<SpriteRenderer>();
        bus = GameObject.FindGameObjectsWithTag("button");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D (Collision2D collision){

        if(bounceNow<=bounceMax){
            bounceNow++;
            SpriteRenderer.color = new Color(1f,1f-(float)bounceNow/(float)bounceMax,1f-(float)bounceNow/(float)bounceMax);
            Debug.Log(1f-(float)bounceNow/(float)bounceMax);
            bou.PlayOneShot(se);
        }else{
            foreach(GameObject b in bus){
                b.SetActive(true);
            }
            Destroy(this.gameObject);
        }
    }
}
