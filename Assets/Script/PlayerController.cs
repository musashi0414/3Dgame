using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FPS
{

    public class PlayerController : MonoBehaviour
    {
        //[Range(0.1f, 10f)]
        ////�J�������x�A���l���傫���قǂ�蒼���I�ȑ��삪�\.
        //public float lookSensitivity = 5f;
        //[Range(0.1f, 1f)]
        ////���l���傫���قǃJ�������������������Ɍ����܂ł̎��Ԃ������Ȃ�.
        //public float lookSmooth = 0.1f;

        //public Vector2 MinMaxAngle = new Vector2(-65, 65);

        //private float yRot;
        //private float xRot;

        //private float currentYRot;
        //private float currentXRot;

        //private float yRotVelocity;
        //private float xRotVelocity;

        private float speed = 8.0f;//�v���C���[�̈ړ����x
        private int count = 1;

       

        

        [SerializeField] Transform TurningPoint_one;
        [SerializeField] Transform TurningPoint_two;
        [SerializeField] Transform TurningPoint_three;

        //internal int score;




        // Start is called before the first frame update
        void Start()
        {

           
        }

        // Update is called once per frame
        void Update()
        {
           
            if (count == 1)
                transform.position = Vector3.MoveTowards(transform.position, TurningPoint_two.position, speed * Time.deltaTime);
            else if (count == 2)
                transform.position = Vector3.MoveTowards(transform.position, TurningPoint_three.position, speed * Time.deltaTime);

            //UpdateCursorLock();

            //yRot += Input.GetAxis("Mouse X") * lookSensitivity; //�}�E�X�̈ړ�.
            //xRot -= Input.GetAxis("Mouse Y") * lookSensitivity; //�}�E�X�̈ړ�.



            //xRot = Mathf.Clamp(xRot, MinMaxAngle.x, MinMaxAngle.y);//�㉺�̊p�x�ړ��̍ő�A�ŏ�.


            //currentXRot = Mathf.SmoothDamp(currentXRot, xRot, ref xRotVelocity, lookSmooth);
            //currentYRot = Mathf.SmoothDamp(currentYRot, yRot, ref yRotVelocity, lookSmooth);

            //transform.rotation = Quaternion.Euler(currentXRot, currentYRot, 0);
           
        }


        private void OnTriggerEnter(Collider other)
        {
            //Debug.Log(count);

           
            if (other.gameObject.name == "TurningPoint_two")
            {
                count = 2;

            }
            else if (other.gameObject.name == "TurningPoint_three")
            {
                SceneManager.LoadScene("ClearScene");
            }
            

        }
    }
}