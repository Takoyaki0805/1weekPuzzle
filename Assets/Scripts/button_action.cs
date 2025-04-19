using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_action : MonoBehaviour
{
    //refactored
    public Button button;
    // public playermove target;
    private GameObject[] player;
    private GameObject target;
    private bool rotating = false;
    private float speed = 1f;
    public bool onturn = false;
    public float accel;
    public GameObject arrow;
    private GameObject system;

    // Start is called before the first frame update
    void Start()
    {
        accel = 0.2f;
        GameObject[] searched_system = GameObject.FindGameObjectsWithTag("System");
        system = searched_system[0]; 
    }

    // Update is called once per frame
    void Update()
    {
        if(rotating){
            player = GameObject.FindGameObjectsWithTag("Player");
            if(player.Length != 0){
                target = player[0];
                target.GetComponent<player_rotate>().ball_rotate(speed);
                arrow.GetComponent<player_rotate>().ball_rotate(speed);
            }
            speed += accel;
            if(speed>5f){
                speed = 5f;
            }
        }
    }

    public void fire(){
        GameObject[] searched_button;
        searched_button = GameObject.FindGameObjectsWithTag("Button");
        player = GameObject.FindGameObjectsWithTag("Player");
        if(player.Length != 0){
            target = player[0];
            target.GetComponent<player_move>().go();
        }
        foreach(GameObject button in searched_button){
            button.SetActive(false);
        }
        Debug.Log("ボタン数:"+searched_button.Length);
    }

    public void rotate(){
        player = GameObject.FindGameObjectsWithTag("Player");
        if(player.Length != 0){
            target = player[0];
            target.GetComponent<player_rotate>().ball_rotate(accel);
        }
    }

    public void button_up(){
        rotating = false;
        speed = 0.1f;
    }

    public void button_down(){
        rotating = true;
    }

    public void bonusstop(){
        system.GetComponent<scoreboard>().setbonus(1);
    }
}
