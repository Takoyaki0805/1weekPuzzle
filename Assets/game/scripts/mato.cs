using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mato : MonoBehaviour
{
    GameObject sc;
    
    public AudioSource o;
    public AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] tmp = GameObject.FindGameObjectsWithTag("sys");
        sc = tmp[0]; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D collision){
        if(collision.gameObject.tag=="Player"){
            AudioSource.PlayClipAtPoint(se,transform.position);
            sc.GetComponent<scoreboard>().score(100);
            sc.GetComponent<scoreboard>().plusbonus(1);
            Destroy(this.gameObject);
        }
        Debug.Log("あたた");
    }
}
