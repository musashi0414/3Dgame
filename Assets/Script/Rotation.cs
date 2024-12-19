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


    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
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

        GetComponent<AudioSource>().Play();  // 効果音を鳴らす
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
