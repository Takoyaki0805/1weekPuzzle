using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_action : MonoBehaviour
{
    public Button button;
    private GameObject[] player;
    private GameObject target;
    private bool IsRotating = false;
    private float speed = 1f;
    public bool IsTurn = false;
    public float button_accel;
    public GameObject arrow;
    private GameObject system;

    // Start is called before the first frame update
    void Start()
    {
        button_accel = 0.2f;
        GameObject[] searched_system = GameObject.FindGameObjectsWithTag("System");
        system = searched_system[0]; 
    }

    // Update is called once per frame
    void Update()
    {
        //加速度を上げながら回転し続ける動作
        if(IsRotating){
            player = GameObject.FindGameObjectsWithTag("Player");
            if(player.Length != 0){
                target = player[0];
                target.GetComponent<Player_rotate>().BallRotate(speed);
                arrow.GetComponent<Player_rotate>().BallRotate(speed);
            }
            //加速上限を設定
            speed += button_accel;
            if(speed>5f){
                speed = 5f;
            }
        }
    }

    //射出ボタンの動作
    public void fire(){
        GameObject[] searched_button;
        searched_button = GameObject.FindGameObjectsWithTag("Button");
        player = GameObject.FindGameObjectsWithTag("Player");
        if(player.Length != 0){
            target = player[0];
            target.GetComponent<Player_move>().PlayerGo();
        }
        foreach(GameObject button in searched_button){
            button.SetActive(false);
        }
        Debug.Log("ボタン数:"+searched_button.Length);
    }

    //回転ボタンの動作
    public void Rotate(){
        player = GameObject.FindGameObjectsWithTag("Player");
        if(player.Length != 0){
            target = player[0];
            target.GetComponent<Player_rotate>().BallRotate(button_accel);
        }
    }

    //ボタンを離したときの動作
    public void ButtonUp(){
        IsRotating = false;
        speed = 0.1f;
    }

    public void ButtonDown(){
        IsRotating = true;
    }

    //連続獲得ボーナス
    public void BonusStop(){
        system.GetComponent<Scoreboard>().SetBonus(1);
    }
}
