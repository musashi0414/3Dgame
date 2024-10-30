using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningMove : MonoBehaviour
{
    [SerializeField] GameObject target;
    private float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�X�^�[�g�ʒu�A�^�[�Q�b�g�̍��W�A���x
        transform.position = Vector3.MoveTowards(
          transform.position,
          target.transform.position,
          speed * Time.deltaTime);
    }
}
