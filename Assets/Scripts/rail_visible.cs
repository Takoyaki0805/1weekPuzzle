using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ターゲットの移動用レールをプレイ時に隠す
public class Rail_visible : MonoBehaviour
{
    //refactored
    public Renderer rail_object;
    public bool IsVisible;
    // Start is called before the first frame update
    void Start()
    {
        rail_object.enabled = IsVisible;
    }
}
