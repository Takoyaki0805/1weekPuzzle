using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoreboard : MonoBehaviour
{
    public Text txt; 
    public int score = 0;
    public int totals = 0;
    int bonus = 0;
    string text_param = "score:";
    string text_tag = "txt";
    int score_lower = 0;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        SceneManager.sceneLoaded += Loaded;
    }
    // Update is called once per frame
    void Update()
    {
        txt.text = text_param + score;    
    }
    //すべてのスコアをリセット
    public void ScoreReset(){
        score = score_lower;
        totals = score_lower;
        bonus = score_lower;
        // Destroy(this.gameObject);
    }
    //ステージスコアをトータルスコアに加算
    public void ScoreMemory(int num){
        score += num*bonus;
        totals += num*bonus;
    }

    public void DecScore(int num){
        score -= num;
        totals -= num;
    }
    //ボーナス点を加算する
    public void SetBonus(int value){
        bonus = value;
    }
    
    public void PlusBonus(int value){
        bonus += value;
    }
    //ロード時にスコアを表示するテキストを取得しステージにスコアをリセットする
    void Loaded(Scene scene,LoadSceneMode e){
        GameObject[] text_obj = GameObject.FindGameObjectsWithTag(text_tag);
        txt =  text_obj[0].GetComponent<Text>();
        score = score_lower;
    }
}
