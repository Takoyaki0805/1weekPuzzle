using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rail_moveX : MonoBehaviour
{
    bool IsDirection = false;
    public float speed = 0.1f;
    string wall_tag_name = "Wall";
    string target_tag_name = "Hit";
    //レールにオブジェクトが触れている間オブジェクトを動かす
    void OnTriggerStay2D (Collider2D collision){
        if(collision.gameObject.tag == wall_tag_name||collision.gameObject.tag == target_tag_name){
            GameObject material = collision.gameObject;
            if(!IsDirection){
                material.transform.position += Vector3.right*speed;
            }else{
                material.transform.position -= Vector3.right*speed;
            }         
        }
    }

    //レールからオブジェクトが抜け出した場合移動の向きを逆にする
    void OnTriggerExit2D (Collider2D collision){
        if(collision.gameObject.tag == wall_tag_name||collision.gameObject.tag == target_tag_name){
            GameObject material = collision.gameObject;
            if(!IsDirection){
                material.transform.position -= Vector3.right*speed;
            }else{
                material.transform.position += Vector3.right*speed;
            }  
            IsDirection = !IsDirection;
        } 
    }
}
