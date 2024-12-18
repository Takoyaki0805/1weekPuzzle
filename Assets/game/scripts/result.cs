using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class result : MonoBehaviour
{
    GameObject[] remain;
    public GameObject r;
    // Start is called before the first frame update
    void Start()
    {
        r.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        remain = GameObject.FindGameObjectsWithTag("hit");
            if(remain.Length == 0){
            GameObject[] bus;
            bus = GameObject.FindGameObjectsWithTag("button");

            foreach(GameObject b in bus){
                b.SetActive(false);
            }

            GameObject[] sum;
            sum = GameObject.FindGameObjectsWithTag("summon");

            foreach(GameObject b in sum){
                b.SetActive(false);
            }

            r.SetActive(true);
        }        
    }

    public void change(string s){
        SceneManager.LoadScene(s);        
    }
}
