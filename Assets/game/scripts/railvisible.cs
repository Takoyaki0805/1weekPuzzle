using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class railvisible : MonoBehaviour
{
    public Renderer obj;
    public bool find;
    // Start is called before the first frame update
    void Start()
    {
        obj.enabled = find;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
