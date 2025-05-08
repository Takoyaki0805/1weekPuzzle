using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_reset : MonoBehaviour
{
    //refactored
    GameObject[] system;
    // Start is called before the first frame update
    void Start()
    {
        system = GameObject.FindGameObjectsWithTag("System");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreRemove(){
        system[0].GetComponent<Scoreboard>().ScoreReset();
    }
}
