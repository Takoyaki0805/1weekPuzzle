using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Audio : MonoBehaviour
{
    public float bgm_volume = 0.7f;
    public float se_volume = 1f;
    GameObject[] player;
    GameObject[] hits;
    string player_tag_name  = "Player";
    string target_tag_name  = "Hit";
    string volume_tag_name  = "Value";
    int bgm_slider_number = 0;
    int se_slider_number = 1;

    // Update is called once per frame
    void Update()
    {
        //効果音の音量を調整するオブジェクトを探索
        player = GameObject.FindGameObjectsWithTag(player_tag_name);
        hits = GameObject.FindGameObjectsWithTag(target_tag_name);
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

    //音量を変える
    public void Change(){
        GameObject[] volume_setting = GameObject.FindGameObjectsWithTag(volume_tag_name);
        if(volume_setting.Length==0){return;}
        Slider volume_bgm = volume_setting[bgm_slider_number].GetComponent<Slider>();
        bgm_volume = volume_bgm.value;

        Slider volume_se = volume_setting[se_slider_number].GetComponent<Slider>();
        se_volume = volume_se.value;
    }
}


