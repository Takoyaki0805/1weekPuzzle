using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoreboard : MonoBehaviour
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
        SceneManager.sceneLoaded += Loaded;
    }

    // Update is called once per frame
    void Update()
    {
        // score(10);
        txt.text = "score:" + score;    
    }

    public void ScoreReset(){
        score = 0;
        totals = 0;
        bonus = 0;
        // Destroy(this.gameObject);
    }

    public void ScoreMemory(int num){
        score += num*bonus;
        totals += num*bonus;
    }

    public void DecScore(int num){
        score -= num;
        totals -= num;
    }

    public void SetBonus(int value){
        bonus = value;
    }

    public void PlusBonus(int value){
        bonus += value;
    }

    void Loaded(Scene scene,LoadSceneMode e){
        GameObject[] text_obj = GameObject.FindGameObjectsWithTag("Txt");
        txt =  text_obj[0].GetComponent<Text>();
        score = 0;
    }
}
