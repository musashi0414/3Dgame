using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoveUp : MonoBehaviour
{
    //private int count = 0;

    //private GameObject scoreText; // ����ǉ��ӏ�
    //public Bullet bullet;
    //private int Status;

    Vector3 startPos;

    void OnCollisionEnter(Collision collision)
    {
        //if (Status == 0)
        //{
        //    bullet.Score += 3;  //�X�R�A���Z���Ă�������
        //    Destroy(this.gameObject);  //�I�u�W�F�N�g�����������ɃX�R�A���Z
        //}
    }

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        //ScoreCount = GameObject.Find("ScoreCount"); // ����ǉ��ӏ� 

    //    bullet = GameObject.Find("SystemMain").GetComponent<Bullet>();
    //    Status = 0;  //0��������Cllision��if�������s�����
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
    //        ScoreCount.GetComponent<ScoreManager>().score = ScoreCount.GetComponent<ScoreManager>().score + 3; // ����ǉ��ӏ�
    //        Destroy(this.gameObject);
    //    }
    //}
}
