using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public string ClearScene;

    

    // Start is called before the first frame update
    void Start()
    {
        //// UI ��������
        //score = 0;
        //SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mato")) // �I���ǂ����̃^�O���`�F�b�N
        {

            //ScoreText.text = string.Format("�X�R�A�F{0}", Score);

            Destroy(other.gameObject); // �G�I�u�W�F�N�g��j��
            Destroy(gameObject); // �e������
        }
    }

    // �ʂ����̃I�u�W�F�N�g�ɂԂ��������ɌĂяo�����
    //void OnTriggerEnter(Collider other)
    //{
    //    // �Ԃ������I�u�W�F�N�g�����W�A�C�e���������ꍇ
    //    if (other.gameObject.CompareTag("Mato"))
    //    {
    //        // ���̎��W�A�C�e�����\���ɂ��܂�
    //        other.gameObject.SetActive(false);

    //        // �X�R�A�����Z���܂�
    //        score = score + 1;

    //        // UI �̕\�����X�V���܂�
    //        SetCountText();
    //    }
    //}

    //// UI �̕\�����X�V����
    //void SetCountText()
    //{
    //    // �X�R�A�̕\�����X�V
    //    scoreText.text = "Count: " + score.ToString();

    //    // ���ׂĂ̎��W�A�C�e�����l�������ꍇ
    //    if (score >= 100)
    //    {
    //        SceneManager.LoadScene(ClearScene);
    //    }
    //}
}
