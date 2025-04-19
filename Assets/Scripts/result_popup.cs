using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class result_popup : MonoBehaviour
{
    //refactored
    GameObject[] remain;
    public GameObject result_UI;
    // Start is called before the first frame update
    void Start()
    {
        result_UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        remain = GameObject.FindGameObjectsWithTag("Hit");
            if(remain.Length == 0){
            GameObject[] buttons;
            buttons = GameObject.FindGameObjectsWithTag("Button");

            foreach(GameObject b in buttons){
                b.SetActive(false);
            }

            GameObject[] sum;
            sum = GameObject.FindGameObjectsWithTag("Summon");

            foreach(GameObject b in sum){
                b.SetActive(false);
            }

            result_UI.SetActive(true);
        }        
    }

    public void change(string s){
        SceneManager.LoadScene(s);        
    }
}
