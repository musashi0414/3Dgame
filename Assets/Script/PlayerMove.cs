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
        //�ړ����x�𒼐ڕύX����
        rb.velocity = new Vector3(0, 0, velocity);
        //if (rb.velocity.magnitude < 10)
        //{
        //    //�w�肵���X�s�[�h���猻�݂̑��x�������ĉ����͂����߂�
        //    float currentSpeed = speed - rb.velocity.magnitude;
        //    //�������ꂽ�����͂ŗ͂�������
        //    rb.AddForce(new Vector3(0, 0, currentSpeed));
        //}
    }
}
