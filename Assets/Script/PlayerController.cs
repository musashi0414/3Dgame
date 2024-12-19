using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FPS
{
    public class PlayerController : MonoBehaviour
    {
       
        private float speed = 8.0f;//プレイヤーの移動速度
        private int count = 1;

        [SerializeField] Transform TurningPoint_one;
        [SerializeField] Transform TurningPoint_two;
        [SerializeField] Transform TurningPoint_three;

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

        }


        private void OnTriggerEnter(Collider other)
        {
            //Debug.Log(count);

           
            if (other.gameObject.name == "TurningPoint_two")            //第一中間地点まで
            {
                count = 2;

            }
            else if (other.gameObject.name == "TurningPoint_three")     //第二中間地点まで
            {
                SceneManager.LoadScene("ClearScene");
            }
        }
    }
}