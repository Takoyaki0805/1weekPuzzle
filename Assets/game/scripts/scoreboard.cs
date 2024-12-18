using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreboard : MonoBehaviour
{
    public Text txt; 
    public int s = 0;
    public int totals = 0;
    int bonus = 0;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        SceneManager.sceneLoaded += loaded;
    }

    // Update is called once per frame
    void Update()
    {
        // score(10);
        txt.text = "score:" + s;    
    }

    public void scoreReset(){
        s = 0;
        totals = 0;
        bonus = 0;
        // Destroy(this.gameObject);
    }

    public void score(int num){
        s += num*bonus;
        totals += num*bonus;;
    }

    public void disscore(int num){
        s -= num;
        totals -= num;
    }

    public void setbonus(int b){
        bonus = b;
    }

    public void plusbonus(int b){
        bonus += b;
    }

    void loaded(Scene sin,LoadSceneMode m){
        GameObject[] tobj = GameObject.FindGameObjectsWithTag("txt");
        txt =  tobj[0].GetComponent<Text>();
        s = 0;
    }
}
