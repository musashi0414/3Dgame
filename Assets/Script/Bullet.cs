using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
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
        if (other.gameObject.CompareTag("Mato")) // �G���ǂ����̃^�O���`�F�b�N
        {
            Destroy(other.gameObject); // �G�I�u�W�F�N�g��j��
            Destroy(gameObject); // �e������
        }
    }
}
