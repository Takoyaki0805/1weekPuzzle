using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Audio : MonoBehaviour
{
    public float bgmV = 0.7f;
    public float seV = 1f;
    GameObject[] p;
    GameObject[] h;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        p = GameObject.FindGameObjectsWithTag("Player");
        h = GameObject.FindGameObjectsWithTag("hit");
        foreach(GameObject a in p){
            AudioSource b = a.GetComponent<AudioSource>();
            b.volume = seV;
        }

        foreach(GameObject a in h){
            AudioSource b = a.GetComponent<AudioSource>();
            b.volume = seV;
        }
        this.gameObject.GetComponent<AudioSource>().volume = bgmV;
        change();
    }

    public void change(){
        GameObject[] v = GameObject.FindGameObjectsWithTag("val");
        if(v.Length==0){return;}
        Slider va = v[0].GetComponent<Slider>();
        bgmV = va.value;

        Slider vb = v[1].GetComponent<Slider>();
        seV = vb.value;

    }
}


