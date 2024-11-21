using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    public Text ScoreText; // スコアの UI
    public Text highScoreText;// ハイスコアを表示する
    private int score; // スコア
    private int highScore;// ハイスコア
    private string highScoreKey = "highScore";// PlayerPrefsで保存するためのキー
    public int scorebox;

   

    // Start is called before the first frame update
    void Start()
    {
        Initialize();

        // UI を初期化
        //score = 0;
        SetCountText();
    }

    private void OnTriggerEnter(Collider other)
    {
        // スコアを加算します
        score = score + 3;
        //score += 3;
        //ScoreText.text = string.Format("スコア:{0}", score);
        

        // UI の表示を更新します
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        // スコアがハイスコアより大きければ
        if (highScore < score)
        {
            highScore = score;
        }

        // スコア・ハイスコアを表示する
        scoreText.text = score.ToString();
        highScoreText.text = highScore.ToString();

        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    // ゲーム開始前の状態に戻す
    private void Initialize()
    {
        // スコアを0に戻す
        score = 0;

        // ハイスコアを取得する。保存されてなければ0を取得する。
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
    }

    // ポイントの追加
    public void AddPoint(int point)
    {
        score = score + point;
    }

    // ハイスコアの保存
    public void Save()
    {
        // ハイスコアを保存する
        PlayerPrefs.SetInt(highScoreKey, highScore);
        PlayerPrefs.Save();

        // ゲーム開始前の状態に戻す
        Initialize();
    }

    // UI の表示を更新する
    void SetCountText()
    {
        // スコアの表示を更新
        ScoreText.text = "Count: " + score.ToString();

        
    }
}
