using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public string ClearScene;
    public Text scoreText; // �X�R�A�� UI
    public Text winText; // ���U���g�� UI

    private GameObject gameObj; //GameObject������ϐ�

    //public static int score = 0;   //�X�R�A

    // Start is called before the first frame update
    void Start()
    {
        gameObj = GameObject.Find("GameObject");//GameObject���擾
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Blue") // �F���ǂ����̃^�O���`�F�b�N
        {


            //gameObj.GetComponent<GameManager>().AddScore();//AddScore()�����s���ĉ��_
            Destroy(collision.gameObject); // �G�I�u�W�F�N�g��j��
            Destroy(gameObject); // �e������
        }
        else if (collision.gameObject.tag == "Red") // �F���ǂ����̃^�O���`�F�b�N
        {


            //gameObj.GetComponent<GameManager>().AddScore();//AddScore()�����s���ĉ��_
            Destroy(collision.gameObject); // �G�I�u�W�F�N�g��j��
            Destroy(gameObject); // �e������
        }
        else if (collision.gameObject.tag == "Yellow") // �F���ǂ����̃^�O���`�F�b�N
        {


            //gameObj.GetComponent<GameManager>().AddScore();//AddScore()�����s���ĉ��_
            Destroy(collision.gameObject); // �G�I�u�W�F�N�g��j��
            Destroy(gameObject); // �e������
        }

    }




}
