using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoButton : MonoBehaviour
{
    public GameObject confirmationPanel;

    // Start is called before the first frame update
    void Start()
    {
        //�m�F�p�l�����\��
        confirmationPanel.SetActive(true);
    }

    public void confirmation()
    {
        //�m�F�p�l�����\��
        confirmationPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
