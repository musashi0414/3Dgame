using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    //public Text ScoreText; // �X�R�A�� UI
    ////public Text highScoreText;// �n�C�X�R�A��\������
    //private int score = 0; // �X�R�A
    //private int highScore;// �n�C�X�R�A

    //public int value = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.CompareTag("Blue"))
        //{
        //    // �X�R�A�����Z���܂�
        //    score = score + 3;
        //}
        //else if (other.gameObject.CompareTag("Yellow"))
        //{
        //    // �X�R�A�����Z���܂�
        //    score = score + 5;
        //}
        //else if (other.gameObject.CompareTag("Red"))
        //{
        //    // �X�R�A�����Z���܂�
        //    score = score + 10;
        //}

        //score += 3;
        //ScoreText.text = string.Format("�X�R�A:{0}", score);

        GetComponent<AudioSource>().Play();  // ���ʉ���炷
    }

    // Update is called once per frame
    void Update()
    {


        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    // �Q�[���J�n�O�̏�Ԃɖ߂�
    //private void Initialize()
    //{

    //}


}
