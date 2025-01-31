using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    
    // AudioSourceを格納する変数
    private AudioSource audioSource;

    // 効果音のAudioClipを設定する変数
    public AudioClip soundEffect;

    // Start is called before the first frame update
    void Start()
    {
        // AudioSourceコンポーネントを取得
        audioSource = GetComponent<AudioSource>();

        // AudioClipが設定されていれば、AudioSourceに適用
        if (soundEffect != null)
        {
            audioSource.clip = soundEffect;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        //if (other.gameObject.tag == "gun") // 青色かどうかのタグをチェック
        //{
        //    GetComponent<AudioSource>().Play();  // 効果音を鳴らす

        //}
        // 効果音を再生
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
