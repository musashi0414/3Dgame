using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public string ClearScene;
    public Text scoreText; // スコアの UI
    public Text winText; // リザルトの UI

    private Rigidbody rb; // Rididbody
    private int score; // スコア


    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody を取得
        rb = GetComponent<Rigidbody>();

        // UI を初期化
        score = 0;
        SetCountText();
        winText.text = "";
        //// UI を初期化
        //score = 0;
        //SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mato")) // 的かどうかのタグをチェック
        {

            //ScoreText.text = string.Format("スコア：{0}", Score);

            Destroy(other.gameObject); // 敵オブジェクトを破壊
            Destroy(gameObject); // 弾も消す

            // スコアを加算します
            score = score + 3;

            // UI の表示を更新します
            SetCountText();
        }
    }

    // UI の表示を更新する
    void SetCountText()
    {
        // スコアの表示を更新
        scoreText.text = "Count: " + score.ToString();

        // すべての収集アイテムを獲得した場合
        if (score >= 100)
        {
            SceneManager.LoadScene(ClearScene);
        }
    }

    // 玉が他のオブジェクトにぶつかった時に呼び出される
    //void OnTriggerEnter(Collider other)
    //{
    //    // ぶつかったオブジェクトが収集アイテムだった場合
    //    if (other.gameObject.CompareTag("Mato"))
    //    {
    //        // その収集アイテムを非表示にします
    //        other.gameObject.SetActive(false);

    //        // スコアを加算します
    //        score = score + 1;

    //        // UI の表示を更新します
    //        SetCountText();
    //    }
    //}


}
