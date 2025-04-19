using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_summon : MonoBehaviour
{
    //refactored
    public GameObject[] issummon;
    public GameObject obj;
    public GameObject maker;
    Quaternion rotate_maker;
    GameObject score_mem;
    // Vector3 pos
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] tmp = GameObject.FindGameObjectsWithTag("sys");
        score_mem = tmp[0];
    }

    // Update is called once per frame
    void Update()
    {
        issummon = GameObject.FindGameObjectsWithTag("Player");
        if(issummon.Length == 0){
            rotate_maker = maker.transform.rotation;
            // pos = this.transform.position;
            rotate_maker *= Quaternion.AngleAxis(90f,Vector3.forward);
            // rotate_maker.z += 90;
            Instantiate(obj,this.transform.position,rotate_maker);
            score_mem.GetComponent<scoreboard>().disscore(10); 
            // Debug.Log(rotate_maker);
        }
    }
}
