using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    //public Text Scoretext;
    //private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mato")) // �I���ǂ����̃^�O���`�F�b�N
        {
            //score += 3;
            //Scoretext.text = string.Format("�X�R�A�F{0}", score);

            Destroy(other.gameObject); // �G�I�u�W�F�N�g��j��
            Destroy(gameObject); // �e������
        }
    }
}
