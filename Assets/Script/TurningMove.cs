using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningMove : MonoBehaviour
{
    //[SerializeField] GameObject target;
    //private float speed = 3.0f;

    ////�X�^�[�g�ƏI���̖ڈ�
    //public Transform TurningPoint_two;
    //public Transform TurningPoint_three;

    //// �X�s�[�h
    //public float speed = 4.0F;

    ////��_�Ԃ̋���������
    //private float distance_two;



    // Start is called before the first frame update
    void Start()
    {
        ////��_�Ԃ̋�������(�X�s�[�h�����Ɏg��)
        //distance_two = Vector3.Distance(TurningPoint_two.position, TurningPoint_three.position);
    }

    // Update is called once per frame
    void Update()
    {
        ////�X�^�[�g�ʒu�A�^�[�Q�b�g�̍��W�A���x
        //transform.position = Vector3.MoveTowards(
        //  transform.position,
        //  target.transform.position,
        //  speed * Time.deltaTime);



        //���݂̈ʒu
        //float present_Location = (Time.time * speed) / distance_two;

        //�I�u�W�F�N�g�̈ړ�
        //transform.position = Vector3.Lerp(TurningPoint_two.position, TurningPoint_three.position, present_Location);
    }

    private void OnTriggerEnter(Collider other)
    {
        //transform.position += Vector3.right * 3 * Time.deltaTime;

        //void Update()
        //{
        //    ////�X�^�[�g�ʒu�A�^�[�Q�b�g�̍��W�A���x
        //    //transform.position = Vector3.MoveTowards(
        //    //  transform.position,
        //    //  target.transform.position,
        //    //  speed * Time.deltaTime);

        //    transform.position += transform.right * 1f * Time.deltaTime;

        //}
    }
}