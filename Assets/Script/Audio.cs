using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioSource Stage;
    
    //public AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    public void OnClickPlay()
    {
        // �I�[�f�B�I���Đ����܂�
        Stage.Play();
    }

    public void OnClickStop()
    {
        // �I�[�f�B�I���~���܂�
        Stage.Stop();
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
