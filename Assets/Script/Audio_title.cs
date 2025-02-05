using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio_title : MonoBehaviour
{
    [SerializeField] private AudioSource TitleBGM;//AudioSource型の変数aを宣言

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    public void OnClickPlay()
    {
        // オーディオを再生します
        TitleBGM.Play();
    }

    public void OnClickStop()
    {
        // オーディオを停止します
        TitleBGM.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
