using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    public Button b;
    // public playermove tar;
    GameObject[] chk;
    GameObject tar;
    bool updown = false;
    float speed = 1f;
    public bool onturn = false;
    public float accel;
    public GameObject sel;
    GameObject sc;

    // Start is called before the first frame update
    void Start()
    {
        accel = 0.2f;
        GameObject[] tmp = GameObject.FindGameObjectsWithTag("sys");
        sc = tmp[0]; 
    }

    // Update is called once per frame
    void Update()
    {
        if(updown){
            chk = GameObject.FindGameObjectsWithTag("Player");
            if(chk.Length != 0){
                tar = chk[0];
                tar.GetComponent<rotate>().rotating(speed);
                sel.GetComponent<rotate>().rotating(speed);
            }
            speed += accel;
            if(speed>5f){
                speed = 5f;
            }
        }
    }

    public void fire(){
        GameObject[] bus;
        bus = GameObject.FindGameObjectsWithTag("button");
        chk = GameObject.FindGameObjectsWithTag("Player");
        if(chk.Length != 0){
            tar = chk[0];
            tar.GetComponent<playermove>().go();
        }
        foreach(GameObject b in bus){
            b.SetActive(false);
        }
        Debug.Log("ボタン数:"+bus.Length);
    }

    public void ro(){
        chk = GameObject.FindGameObjectsWithTag("Player");
        if(chk.Length != 0){
            tar = chk[0];
            tar.GetComponent<rotate>().rotating(accel);
        }
    }

    public void roup(){
        updown = false;
        speed = 0.1f;
    }

    public void rodown(){
        updown = true;
    }

    public void bonusstop(){
        sc.GetComponent<scoreboard>().setbonus(1);
    }
}
