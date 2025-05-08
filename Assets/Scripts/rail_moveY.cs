using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rail_moveY : MonoBehaviour
{
    //refactored
    bool IsDirection = false;
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //レールにオブジェクトが触れている間オブジェクトを動かす
    void OnTriggerStay2D (Collider2D collision){
        if(collision.gameObject.tag=="Wall"||collision.gameObject.tag=="Hit"){
            GameObject material = collision.gameObject;
            if(!IsDirection){
                material.transform.position += Vector3.up*speed;
            }else{
                material.transform.position -= Vector3.up*speed;
            }         
        }
    }

    //レールにオブジェクトが触れている間オブジェクトを動かす
    void OnTriggerExit2D (Collider2D collision){
        if(collision.gameObject.tag=="Wall"||collision.gameObject.tag=="Hit"){
            GameObject material = collision.gameObject;
            if(!IsDirection){
                material.transform.position -= Vector3.up*speed;
            }else{
                material.transform.position += Vector3.up*speed;
            }  
            IsDirection = !IsDirection;
        } 
    }
}
