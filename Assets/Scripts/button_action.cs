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
    string system_tag_name = "System";
    string player_tag_name = "Player";
    string button_tag_name = "Button";
    float speed_max = 5f;
    float accel_reset = 0.1f;
    float accel_reset = 0.1f;
    int bonus_reset = 1;


    // Start is called before the first frame update
    void Start()
    {
        button_accel = 0.2f;
        GameObject[] searched_system = GameObject.FindGameObjectsWithTag(system_tag_name);
        system = searched_system[0]; 
    }

    // Update is called once per frame
    void Update()
    {
        //加速度を上げながら回転し続ける動作
        if(IsRotating){
            player = GameObject.FindGameObjectsWithTag(player_tag_name);
            if(player.Length != 0){
                target = player[0];
                target.GetComponent<Player_rotate>().BallRotate(speed);
                arrow.GetComponent<Player_rotate>().BallRotate(speed);
            }
            //加速上限を設定
            speed += button_accel;
            if(speed > speed_max){
                speed = speed_max;
            }
        }
    }

    //射出ボタンの動作
    public void fire(){
        GameObject[] searched_button;
        searched_button = GameObject.FindGameObjectsWithTag(button_tag_name);
        player = GameObject.FindGameObjectsWithTag(player_tag_name);
        if(player.Length != 0){
            target = player[0];
            target.GetComponent<Player_move>().PlayerGo();
        }
        foreach(GameObject button in searched_button){
            button.SetActive(false);
        }
    }

    //回転ボタンの動作
    public void Rotate(){
        player = GameObject.FindGameObjectsWithTag(player_tag_name);
        if(player.Length != 0){
            target = player[0];
            target.GetComponent<Player_rotate>().BallRotate(button_accel);
        }
    }

    //ボタンを離したときの動作
    public void ButtonUp(){
        IsRotating = false;
        speed = accel_reset;
    }

    public void ButtonDown(){
        IsRotating = true;
    }

    //連続獲得ボーナス
    public void BonusStop(){
        system.GetComponent<Scoreboard>().SetBonus(bonus_reset);
    }
}
