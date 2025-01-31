using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    
    // AudioSource���i�[����ϐ�
    private AudioSource audioSource;

    // ���ʉ���AudioClip��ݒ肷��ϐ�
    public AudioClip soundEffect;

    // Start is called before the first frame update
    void Start()
    {
        // AudioSource�R���|�[�l���g���擾
        audioSource = GetComponent<AudioSource>();

        // AudioClip���ݒ肳��Ă���΁AAudioSource�ɓK�p
        if (soundEffect != null)
        {
            audioSource.clip = soundEffect;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        //if (other.gameObject.tag == "gun") // �F���ǂ����̃^�O���`�F�b�N
        //{
        //    GetComponent<AudioSource>().Play();  // ���ʉ���炷

        //}
        // ���ʉ����Đ�
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.PlayOneShot(soundEffect);
        }
    }

    // Update is called once per frame
    void Update()
    {


        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    

}
