using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Audio : MonoBehaviour
{
    //refactored
    public float bgm_volume = 0.7f;
    public float se_volume = 1f;
    GameObject[] player;
    GameObject[] hits;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
        hits = GameObject.FindGameObjectsWithTag("Hit");
        foreach(GameObject i in player){
            AudioSource bounse_se = i.GetComponent<AudioSource>();
            bounse_se.volume = se_volume;
        }

        foreach(GameObject j in hits){
            AudioSource target_se = j.GetComponent<AudioSource>();
            target_se.volume = se_volume;
        }
        this.gameObject.GetComponent<AudioSource>().volume = bgm_volume;
        Change();
    }

    public void Change(){
        GameObject[] volume_setting = GameObject.FindGameObjectsWithTag("Value");
        if(volume_setting.Length==0){return;}
        Slider volume_bgm = volume_setting[0].GetComponent<Slider>();
        bgm_volume = volume_bgm.value;

        Slider volume_se = volume_setting[1].GetComponent<Slider>();
        se_volume = volume_se.value;

    }
}


