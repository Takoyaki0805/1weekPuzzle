using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class result_popup : MonoBehaviour
{
    GameObject[] remain_target;
    public GameObject result_UI;
    string target_tag_name = "Hit";
    string button_tag_name = "Button";
    string summon_tag_name = "Summon";
    // Start is called before the first frame update
    void Start()
    {
        result_UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        remain_target = GameObject.FindGameObjectsWithTag(target_tag_name);
        //ターゲットの数が0になったらボタンを削除してリザルトを表示させる
        if(remain_target.Length == 0){
            GameObject[] buttons;
            buttons = GameObject.FindGameObjectsWithTag(button_tag_name);
            foreach(GameObject b in buttons){
                b.SetActive(false);
            }
            GameObject[] summon;
            summon = GameObject.FindGameObjectsWithTag(summon_tag_name);
            foreach(GameObject b in summon){
                b.SetActive(false);
            }
            result_UI.SetActive(true);
        }        
    }

    public void Change(string s){
        SceneManager.LoadScene(s);        
    }
}
