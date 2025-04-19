using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_rotate : MonoBehaviour
{
    //refactored
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ball_rotate(float accel){
        this.transform.Rotate(0f,0f,accel);
    }
}
