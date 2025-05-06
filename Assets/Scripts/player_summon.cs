using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_summon : MonoBehaviour
{
    //refactored
    public GameObject[] player_summon;
    public GameObject player_object;
    public GameObject spawn_maker;
    Quaternion rotate_maker;
    GameObject score_memory;
    // Vector3 pos
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] system_object = GameObject.FindGameObjectsWithTag("System");
        score_memory = system_object[0];
    }

    // Update is called once per frame
    void Update()
    {
        player_summon = GameObject.FindGameObjectsWithTag("Player");
        if(player_summon.Length == 0){
            rotate_maker = spawn_maker.transform.rotation;
            // pos = this.transform.position;
            rotate_maker *= Quaternion.AngleAxis(90f,Vector3.forward);
            // rotate_maker.z += 90;
            Instantiate(player_object,this.transform.position,rotate_maker);
            score_memory.GetComponent<Scoreboard>().DecScore(10); 
            // Debug.Log(rotate_maker);
        }
    }
}
