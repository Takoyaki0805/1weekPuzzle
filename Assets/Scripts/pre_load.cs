using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pre_load : MonoBehaviour
{
    string title_scene_name = "title";
    //初期設定シーンからタイトル画面に移動するイベント用
    // Update is called once per frame
    void Update()
    {
        //シーンを読み込んだあとすぐ移動するのでUpdate
        SceneManager.LoadScene(title_scene_name);
    }
}
