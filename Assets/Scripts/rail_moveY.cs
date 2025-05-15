using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rail_moveY : MonoBehaviour
{
    //refactored
    bool IsDirection = false;
    public float speed = 0.1f;
    string wall_tag_name ="Wall"; 
    string target_tag_name ="Hit"; 

    //レールにオブジェクトが触れている間オブジェクトを動かす
    void OnTriggerStay2D (Collider2D collision){
        if(collision.gameObject.tag == wall_tag_name||collision.gameObject.tag == target_tag_name){
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
        if(collision.gameObject.tag == wall_tag_name||collision.gameObject.tag == target_tag_name){
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
