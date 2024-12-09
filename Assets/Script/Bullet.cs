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

    private GameObject gameObj; //GameObjectを入れる変数

    //public static int score = 0;   //スコア

    // Start is called before the first frame update
    void Start()
    {
        gameObj = GameObject.Find("GameObject");//GameObjectを取得
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Blue") // 青色かどうかのタグをチェック
        {


            //gameObj.GetComponent<GameManager>().AddScore();//AddScore()を実行して加点
            Destroy(collision.gameObject); // 敵オブジェクトを破壊
            Destroy(gameObject); // 弾も消す
        }
        else if (collision.gameObject.tag == "Red") // 青色かどうかのタグをチェック
        {


            //gameObj.GetComponent<GameManager>().AddScore();//AddScore()を実行して加点
            Destroy(collision.gameObject); // 敵オブジェクトを破壊
            Destroy(gameObject); // 弾も消す
        }
        else if (collision.gameObject.tag == "Yellow") // 青色かどうかのタグをチェック
        {


            //gameObj.GetComponent<GameManager>().AddScore();//AddScore()を実行して加点
            Destroy(collision.gameObject); // 敵オブジェクトを破壊
            Destroy(gameObject); // 弾も消す
        }

    }




}
