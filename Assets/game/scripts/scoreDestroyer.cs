using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreDestroyer : MonoBehaviour
{
    GameObject[] sys;
    // Start is called before the first frame update
    void Start()
    {
        sys = GameObject.FindGameObjectsWithTag("sys");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void remover(){
        sys[0].GetComponent<scoreboard>().scoreReset();
    }
}
