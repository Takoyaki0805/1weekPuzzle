using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_move : MonoBehaviour
{
    //refactored
    public Rigidbody2D rig;  
    public float speed;
    public bool IsMove = false;
    // Start is called before the first frame update
    void Start()
    {
        IsMove = false;
        rig = this.gameObject.GetComponent<Rigidbody2D>();
        this.gameObject.name = "player";
    }

    // Update is called once per frame
    void Update()
    {
        if(IsMove){
            rig.gravityScale = 1;
        }else{
            rig.gravityScale = 0;
            rig.velocity = new Vector2(0,0);
        }
    }

    public void PlayerGo(){
        IsMove = true;
        rig.AddForce(transform.right*speed,ForceMode2D.Impulse);
    }
}
