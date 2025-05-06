using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class railvisible : MonoBehaviour
{
    //refactored
    public Renderer rail_object;
    public bool IsVisible;
    // Start is called before the first frame update
    void Start()
    {
        rail_object.enabled = IsVisible;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
