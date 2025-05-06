using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class result_popup : MonoBehaviour
{
    //refactored
    GameObject[] remain_target;
    public GameObject result_UI;
    // Start is called before the first frame update
    void Start()
    {
        result_UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        remain_target = GameObject.FindGameObjectsWithTag("Hit");
            if(remain_target.Length == 0){
            GameObject[] buttons;
            buttons = GameObject.FindGameObjectsWithTag("Button");

            foreach(GameObject b in buttons){
                b.SetActive(false);
            }

            GameObject[] summon;
            summon = GameObject.FindGameObjectsWithTag("Summon");

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
