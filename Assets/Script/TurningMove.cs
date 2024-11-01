using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningMove : MonoBehaviour
{
    //[SerializeField] GameObject target;
    //private float speed = 3.0f;

    ////スタートと終わりの目印
    //public Transform TurningPoint_two;
    //public Transform TurningPoint_three;

    //// スピード
    //public float speed = 4.0F;

    ////二点間の距離を入れる
    //private float distance_two;



    // Start is called before the first frame update
    void Start()
    {
        ////二点間の距離を代入(スピード調整に使う)
        //distance_two = Vector3.Distance(TurningPoint_two.position, TurningPoint_three.position);
    }

    // Update is called once per frame
    void Update()
    {
        ////スタート位置、ターゲットの座標、速度
        //transform.position = Vector3.MoveTowards(
        //  transform.position,
        //  target.transform.position,
        //  speed * Time.deltaTime);



        //現在の位置
        //float present_Location = (Time.time * speed) / distance_two;

        //オブジェクトの移動
        //transform.position = Vector3.Lerp(TurningPoint_two.position, TurningPoint_three.position, present_Location);
    }

    private void OnTriggerEnter(Collider other)
    {
        //transform.position += Vector3.right * 3 * Time.deltaTime;

        //void Update()
        //{
        //    ////スタート位置、ターゲットの座標、速度
        //    //transform.position = Vector3.MoveTowards(
        //    //  transform.position,
        //    //  target.transform.position,
        //    //  speed * Time.deltaTime);

        //    transform.position += transform.right * 1f * Time.deltaTime;

        //}
    }
}