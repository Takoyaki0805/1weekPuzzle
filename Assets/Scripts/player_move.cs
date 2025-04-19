using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player_move : MonoBehaviour
{
    //refactored
    public Rigidbody2D rig;  
    public float speed;
    public bool ismove = false;
    // Start is called before the first frame update
    void Start()
    {
        ismove = false;
        rig = this.gameObject.GetComponent<Rigidbody2D>();
        this.gameObject.name = "player";
    }

    // Update is called once per frame
    void Update()
    {
        if(ismove){
            rig.gravityScale = 1;
        }else{
            rig.gravityScale = 0;
            rig.velocity = new Vector2(0,0);
        }
    }

    public void go(){
        ismove = true;
        rig.AddForce(transform.right*speed,ForceMode2D.Impulse);
    }
}
