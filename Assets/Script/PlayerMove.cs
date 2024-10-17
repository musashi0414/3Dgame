using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;
    public float velocity = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //移動速度を直接変更する
        rb.velocity = new Vector3(0, 0, velocity);
        //if (rb.velocity.magnitude < 10)
        //{
        //    //指定したスピードから現在の速度を引いて加速力を求める
        //    float currentSpeed = speed - rb.velocity.magnitude;
        //    //調整された加速力で力を加える
        //    rb.AddForce(new Vector3(0, 0, currentSpeed));
        //}
    }
}
