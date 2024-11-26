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

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag=="Blue") // 的かどうかのタグをチェック
        {
            //スコアアイテム
            ItemData item = collision.gameobject.GetComponent<ItemData>();
            //スコアを得る
            score = item.vallue;

            Destroy(collision.gameObject); // 敵オブジェクトを破壊
            Destroy(gameObject); // 弾も消す  
        }
        //else if (other.gameObject.CompareTag("Red")) // 的かどうかのタグをチェック
        //{
        //    Destroy(other.gameObject); // 敵オブジェクトを破壊
        //    Destroy(gameObject); // 弾も消す
        //}
        //else if (other.gameObject.CompareTag("Yellow")) // 的かどうかのタグをチェック
        //{
        //    Destroy(other.gameObject); // 敵オブジェクトを破壊
        //    Destroy(gameObject); // 弾も消す
        //}
    }

   


}
