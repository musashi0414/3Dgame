using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public int hitPoint = 10;  //HP

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //HP��0�ɂȂ����Ƃ��ɓG��j�󂷂�
        if (hitPoint <= 0)
        {
            Destroy(gameObject);
        }
    }

    //�_���[�W���󂯎����HP�����炷�֐�
    public void Damage(int damage)
    {
        //�󂯎�����_���[�W��HP�����炷
        hitPoint -= damage;
    }
}
