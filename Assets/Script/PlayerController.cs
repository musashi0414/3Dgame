using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{

    public class PlayerController : MonoBehaviour
    {
        [Range(0.1f, 10f)]
        //�J�������x�A���l���傫���قǂ�蒼���I�ȑ��삪�\.
        public float lookSensitivity = 5f;
        [Range(0.1f, 1f)]
        //���l���傫���قǃJ�������������������Ɍ����܂ł̎��Ԃ������Ȃ�.
        public float lookSmooth = 0.1f;

        public Vector2 MinMaxAngle = new Vector2(-65, 65);

        private float yRot;
        private float xRot;

        private float currentYRot;
        private float currentXRot;

        private float yRotVelocity;
        private float xRotVelocity;

        [SerializeField] private Transform[] point;

        //[SerializeField] GameObject target;
        //private float speed = 5.0f;

        //�X�^�[�g�ƏI���̖ڈ�
        public Transform TurningPoint_one;
        public Transform TurningPoint_two;
        

        // �X�s�[�h
        public float speed = 4.0F;

        //��_�Ԃ̋���������
        private float distance_two;


        // Start is called before the first frame update
        void Start()
        {
            //��_�Ԃ̋�������(�X�s�[�h�����Ɏg��)
            distance_two = Vector3.Distance(TurningPoint_one.position, TurningPoint_two.position);


           
        }

        // Update is called once per frame
        void Update()
        {
            //�v���C���[�̈ړ��A��O���Ԓn�_�܂ňړ�
            //   transform.position = Vector3.MoveTowards(
            //transform.position,
            //target.transform.position,
            //speed * Time.deltaTime);
            // ���݂̈ʒu
            float present_Location = (Time.time * speed) / distance_two;
            // �I�u�W�F�N�g�̈ړ�
            transform.position = Vector3.Lerp(TurningPoint_one.position, TurningPoint_two.position, present_Location);
            

            //UpdateCursorLock();

            yRot += Input.GetAxis("Mouse X") * lookSensitivity; //�}�E�X�̈ړ�.
            xRot -= Input.GetAxis("Mouse Y") * lookSensitivity; //�}�E�X�̈ړ�.



            xRot = Mathf.Clamp(xRot, MinMaxAngle.x, MinMaxAngle.y);//�㉺�̊p�x�ړ��̍ő�A�ŏ�.


            currentXRot = Mathf.SmoothDamp(currentXRot, xRot, ref xRotVelocity, lookSmooth);
            currentYRot = Mathf.SmoothDamp(currentYRot, yRot, ref yRotVelocity, lookSmooth);

            transform.rotation = Quaternion.Euler(currentXRot, currentYRot, 0);
        }


        private void OnTriggerEnter(Collider other)
        {
            //transform.position += Vector3.right * 3 * Time.deltaTime;

            if (other.gameObject.tag == "two")
            {
                transform.Rotate(new Vector3(0, 90, 0));
            }



        }
    }
}