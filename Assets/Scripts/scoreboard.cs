using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreboard : MonoBehaviour
{
    //refactored
    public Text txt; 
    public int score = 0;
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
        txt.text = "score:" + score;    
    }

    public void scoreReset(){
        score = 0;
        totals = 0;
        bonus = 0;
        // Destroy(this.gameObject);
    }

    public void score_memory(int num){
        score += num*bonus;
        totals += num*bonus;
    }

    public void disscore(int num){
        score -= num;
        totals -= num;
    }

    public void setbonus(int value){
        bonus = value;
    }

    public void plusbonus(int value){
        bonus += value;
    }

    void loaded(Scene scene,LoadSceneMode e){
        GameObject[] text_obj = GameObject.FindGameObjectsWithTag("Txt");
        txt =  text_obj[0].GetComponent<Text>();
        score = 0;
    }
}
