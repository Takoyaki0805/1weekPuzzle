using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_move : MonoBehaviour
{
    public Rigidbody2D rig;  
    public float speed;
    public bool IsMove = false;
    string player_object_name = "player";
    float gravity_max = 1f;
    float gravity_min = 0f;
    // Start is called before the first frame update
    void Start()
    {
        IsMove = false;
        rig = this.gameObject.GetComponent<Rigidbody2D>();
        this.gameObject.name = player_object_name
    }

    // Update is called once per frame
    void Update()
    {
        //ボタンが押されるまで重力をなくす
        if(IsMove){
            rig.gravityScale = gravity_max;
        }else{
            rig.gravityScale = gravity_min;
            rig.velocity = new Vector2(0,0);
        }
    }

    //ボタンが押されたら重力を戻し自機を加速させる
    public void PlayerGo(){
        IsMove = true;
        rig.AddForce(transform.right*speed,ForceMode2D.Impulse);
    }
}
