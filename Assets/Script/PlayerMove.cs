using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //[SerializeField] private Transform[] point;

    //[SerializeField] GameObject target;
    //private float speed = 3.0f;

    //[SerializeField] GameObject target;
    //private float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     //   //プレイヤーの移動、第一中間地点まで移動
     //   transform.position = Vector3.MoveTowards(
     //transform.position,
     //target.transform.position,
     //speed * Time.deltaTime);
    }

    //void OnTriggerEnter(Collision collision)
    //{
    //    //プレイヤーの移動、第一中間地点まで移動
    //    transform.position = Vector3.MoveTowards(
    // transform.position,
    // target.transform.position,
    // speed * Time.deltaTime);
    //}

    //void OnTriggerEnter(Collision collision)
    //{
    //    if (collision.gameobject.name == "TurningPoint")
    //    {
    //        //スタート位置、ターゲットの座標、速度
    //        transform.position = Vector3.MoveTowards(
    //          transform.position,
    //          target.transform.position,
    //          speed * Time.deltaTime);
    //    }
    //}
}
