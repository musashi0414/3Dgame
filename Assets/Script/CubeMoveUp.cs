using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoveUp : MonoBehaviour
{
    //private int count = 0;

    //private GameObject scoreText; // 今回追加箇所
    //public Bullet bullet;
    //private int Status;

    Vector3 startPos;

    void OnCollisionEnter(Collision collision)
    {
        //if (Status == 0)
        //{
        //    bullet.Score += 3;  //スコア加算していく数字
        //    Destroy(this.gameObject);  //オブジェクトが消えた時にスコア加算
        //}
    }

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        //ScoreCount = GameObject.Find("ScoreCount"); // 今回追加箇所 

    //    bullet = GameObject.Find("SystemMain").GetComponent<Bullet>();
    //    Status = 0;  //0だったらCllisionのif文が実行される
    }

    // Update is called once per frame
    void Update()
    {
        float posY = startPos.y + Mathf.Sin(Time.time) * 4;
        transform.position = new Vector3(transform.position.x, posY, transform.position.z);
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.name == "gun")
    //    {
    //        Debug.Log("BulletCollision");
    //        ScoreCount.GetComponent<ScoreManager>().score = ScoreCount.GetComponent<ScoreManager>().score + 3; // 今回追加箇所
    //        Destroy(this.gameObject);
    //    }
    //}
}
