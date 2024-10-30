using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
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
        if (other.gameObject.CompareTag("Mato")) // 敵かどうかのタグをチェック
        {
            Destroy(other.gameObject); // 敵オブジェクトを破壊
            Destroy(gameObject); // 弾も消す
        }
    }
}
