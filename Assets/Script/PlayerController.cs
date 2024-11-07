using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FPS
{

    public class PlayerController : MonoBehaviour
    {
        [Range(0.1f, 10f)]
        //カメラ感度、数値が大きいほどより直感的な操作が可能.
        public float lookSensitivity = 5f;
        [Range(0.1f, 1f)]
        //数値が大きいほどカメラが向きたい方向に向くまでの時間が長くなる.
        public float lookSmooth = 0.1f;

        public Vector2 MinMaxAngle = new Vector2(-65, 65);

        private float yRot;
        private float xRot;

        private float currentYRot;
        private float currentXRot;

        private float yRotVelocity;
        private float xRotVelocity;

        private float speed = 8.0f;
        private int count = 1;

        [SerializeField] Transform TurningPoint_one;
        [SerializeField] Transform TurningPoint_two;
        [SerializeField] Transform TurningPoint_three;

        //[SerializeField] private Transform[] point;

        //[SerializeField] GameObject target;
        //private float speed = 5.0f;

        ////スタートと終わりの目印
        //public Transform TurningPoint_one;
        //public Transform TurningPoint_two;


        //// スピード
        //public float speed = 4.0F;

        ////二点間の距離を入れる
        //private float distance_two


        // Start is called before the first frame update
        void Start()
        {
            ////二点間の距離を代入(スピード調整に使う)
            //distance_two = Vector3.Distance(TurningPoint_one.position, TurningPoint_two.position);


           
        }

        // Update is called once per frame
        void Update()
        {
            //プレイヤーの移動、第三中間地点まで移動
            //   transform.position = Vector3.MoveTowards(
            //transform.position,
            //target.transform.position,
            //speed * Time.deltaTime);

            //// 現在の位置
            //float present_Location = (Time.time * speed) / distance_two;
            //// オブジェクトの移動
            //transform.position = Vector3.Lerp(TurningPoint_one.position, TurningPoint_two.position, present_Location);
            //if (count == 0)
            //    transform.position = Vector3.MoveTowards(transform.position, TurningPoint_one.position, speed * Time.deltaTime);
            if (count == 1)
                transform.position = Vector3.MoveTowards(transform.position, TurningPoint_two.position, speed * Time.deltaTime);
            else if (count == 2)
                transform.position = Vector3.MoveTowards(transform.position, TurningPoint_three.position, speed * Time.deltaTime);

            //UpdateCursorLock();

            yRot += Input.GetAxis("Mouse X") * lookSensitivity; //マウスの移動.
            xRot -= Input.GetAxis("Mouse Y") * lookSensitivity; //マウスの移動.



            xRot = Mathf.Clamp(xRot, MinMaxAngle.x, MinMaxAngle.y);//上下の角度移動の最大、最小.


            currentXRot = Mathf.SmoothDamp(currentXRot, xRot, ref xRotVelocity, lookSmooth);
            currentYRot = Mathf.SmoothDamp(currentYRot, yRot, ref yRotVelocity, lookSmooth);

            transform.rotation = Quaternion.Euler(currentXRot, currentYRot, 0);
        }


        private void OnTriggerEnter(Collider other)
        {
            //Debug.Log(count);

            //transform.position += Vector3.right * 3 * Time.deltaTime;

            //if (other.gameObject.tag == "two")
            //{
            //    transform.Rotate(new Vector3(0, 90, 0));
            //}
            //if (other.gameObject.name == "TurningPoint_one")
            //{
            //    count = 1;
            //}
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