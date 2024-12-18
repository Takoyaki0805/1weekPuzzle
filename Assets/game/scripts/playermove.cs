using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playermove : MonoBehaviour
{
    public Rigidbody2D rb;  
    public float speed;
    public bool ismove = false;
    // Start is called before the first frame update
    void Start()
    {
        ismove = false;
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        this.gameObject.name = "player";
    }

    // Update is called once per frame
    void Update()
    {
        if(ismove){
            rb.gravityScale = 1;
        }else{
            rb.gravityScale = 0;
            rb.velocity = new Vector2(0,0);
        }
    }

    public void go(){
        ismove = true;
        rb.AddForce(transform.right*speed,ForceMode2D.Impulse);
    }
}
