using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    //public Text ScoreText; // スコアの UI
    ////public Text highScoreText;// ハイスコアを表示する
    //private int score = 0; // スコア
    //private int highScore;// ハイスコア

    //public int value = 0;
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
        //if (other.gameObject.CompareTag("Blue"))
        //{
        //    // スコアを加算します
        //    score = score + 3;
        //}
        //else if (other.gameObject.CompareTag("Yellow"))
        //{
        //    // スコアを加算します
        //    score = score + 5;
        //}
        //else if (other.gameObject.CompareTag("Red"))
        //{
        //    // スコアを加算します
        //    score = score + 10;
        //}

        //score += 3;
        //ScoreText.text = string.Format("スコア:{0}", score);
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

    // ゲーム開始前の状態に戻す
    //private void Initialize()
    //{

    //}


}
