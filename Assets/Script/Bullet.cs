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

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag=="Blue") // �I���ǂ����̃^�O���`�F�b�N
        {
            //�X�R�A�A�C�e��
            ItemData item = collision.gameobject.GetComponent<ItemData>();
            //�X�R�A�𓾂�
            score = item.vallue;

            Destroy(collision.gameObject); // �G�I�u�W�F�N�g��j��
            Destroy(gameObject); // �e������  
        }
        //else if (other.gameObject.CompareTag("Red")) // �I���ǂ����̃^�O���`�F�b�N
        //{
        //    Destroy(other.gameObject); // �G�I�u�W�F�N�g��j��
        //    Destroy(gameObject); // �e������
        //}
        //else if (other.gameObject.CompareTag("Yellow")) // �I���ǂ����̃^�O���`�F�b�N
        //{
        //    Destroy(other.gameObject); // �G�I�u�W�F�N�g��j��
        //    Destroy(gameObject); // �e������
        //}
    }

   


}
