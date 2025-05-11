using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//自機を回転させるクラス
public class Player_rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BallRotate(float accel){
        this.transform.Rotate(0f,0f,accel);
    }
}
