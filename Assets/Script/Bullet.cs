using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public string ClearScene;

    private int score;
    //public Text scoreText; // スコアの UI
    //public Text winText; // リザルトの UI

    private GameObject gameObj_blue; //GameObjectを入れる変数
    private GameObject gameObj_yellow; //GameObjectを入れる変数
    private GameObject gameObj_red; //GameObjectを入れる変数

    //public static int score = 0;   //スコア

    // Start is called before the first frame update
    void Start()
    {
        gameObj_blue = GameObject.Find("GameObject");//GameObjectを取得
        gameObj_yellow = GameObject.Find("GameObject");//GameObjectを取得
        gameObj_red = GameObject.Find("GameObject");//GameObjectを取得
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Blue") // 青色かどうかのタグをチェック
        {

            Debug.Log(score);
            gameObj_blue.GetComponent<Score_Blue>().AddScore();//AddScore()を実行して加点
            Destroy(other.gameObject); // 敵オブジェクトを破壊
            Destroy(gameObject); // 弾も消す
        }
        else if (other.gameObject.tag == "Yellow") // 黄色かどうかのタグをチェック
        {


            gameObj_yellow.GetComponent<Score_Yellow>().AddScore();//AddScore()を実行して加点
            Destroy(other.gameObject); // 敵オブジェクトを破壊
            Destroy(gameObject); // 弾も消す
        }
        else if (other.gameObject.tag == "Red") // 赤色かどうかのタグをチェック
        {


            gameObj_red.GetComponent<Score_Red>().AddScore();//AddScore()を実行して加点
            Destroy(other.gameObject); // 敵オブジェクトを破壊
            Destroy(gameObject); // 弾も消す
        }

    }




}
