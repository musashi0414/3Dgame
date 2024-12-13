using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public string ClearScene;
    //public Text scoreText; // �X�R�A�� UI
    //public Text winText; // ���U���g�� UI

    private GameObject gameObj_blue; //GameObject������ϐ�
    private GameObject gameObj_yellow; //GameObject������ϐ�
    private GameObject gameObj_red; //GameObject������ϐ�

    //public static int score = 0;   //�X�R�A

    // Start is called before the first frame update
    void Start()
    {
        gameObj_blue = GameObject.Find("GameObject");//GameObject���擾
        gameObj_yellow = GameObject.Find("GameObject");//GameObject���擾
        gameObj_red = GameObject.Find("GameObject");//GameObject���擾
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Blue") // �F���ǂ����̃^�O���`�F�b�N
        {


            gameObj_blue.GetComponent<GameManager>().AddScore();//AddScore()�����s���ĉ��_
            Destroy(collider.gameObject); // �G�I�u�W�F�N�g��j��
            Destroy(gameObject); // �e������
        }
        else if (collider.gameObject.tag == "Red") // �F���ǂ����̃^�O���`�F�b�N
        {


            gameObj_yellow.GetComponent<GameManager>().AddScore();//AddScore()�����s���ĉ��_
            Destroy(collider.gameObject); // �G�I�u�W�F�N�g��j��
            Destroy(gameObject); // �e������
        }
        else if (collider.gameObject.tag == "Yellow") // �F���ǂ����̃^�O���`�F�b�N
        {


            gameObj_red.GetComponent<GameManager>().AddScore();//AddScore()�����s���ĉ��_
            Destroy(collider.gameObject); // �G�I�u�W�F�N�g��j��
            Destroy(gameObject); // �e������
        }

    }




}
