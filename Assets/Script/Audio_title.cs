using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio_title : MonoBehaviour
{
    [SerializeField] private AudioSource TitleBGM;//AudioSource�^�̕ϐ�a��錾

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    public void OnClickPlay()
    {
        // �I�[�f�B�I���Đ����܂�
        TitleBGM.Play();
    }

    public void OnClickStop()
    {
        // �I�[�f�B�I���~���܂�
        TitleBGM.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
