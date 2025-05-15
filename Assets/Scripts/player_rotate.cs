using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//自機を回転させるクラス
public class Player_rotate : MonoBehaviour
{
    float none_rotate = 0f;
    public void BallRotate(float accel){
        this.transform.Rotate(none_rotate,none_rotate,accel);
    }
}
