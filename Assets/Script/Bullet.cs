using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    //public Text Scoretext;
    //private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mato")) // 的かどうかのタグをチェック
        {
            //score += 3;
            //Scoretext.text = string.Format("スコア：{0}", score);

            Destroy(other.gameObject); // 敵オブジェクトを破壊
            Destroy(gameObject); // 弾も消す
        }
    }
}
