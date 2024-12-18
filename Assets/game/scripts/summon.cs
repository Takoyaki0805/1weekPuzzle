using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summon : MonoBehaviour
{
    public GameObject[] issummon;
    public GameObject Obj;
    public GameObject Maker;
    Quaternion rotateMaker;
    GameObject sc;
    // Vector3 pos
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] tmp = GameObject.FindGameObjectsWithTag("sys");
        sc = tmp[0];
    }

    // Update is called once per frame
    void Update()
    {
        issummon = GameObject.FindGameObjectsWithTag("Player");
        if(issummon.Length == 0){
            rotateMaker = Maker.transform.rotation;
            // pos = this.transform.position;
            rotateMaker *= Quaternion.AngleAxis(90f,Vector3.forward);
            // rotateMaker.z += 90;
            Instantiate(Obj,this.transform.position,rotateMaker);
            sc.GetComponent<scoreboard>().disscore(10); 
            // Debug.Log(rotateMaker);
        }
    }
}
