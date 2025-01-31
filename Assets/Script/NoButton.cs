using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoButton : MonoBehaviour
{
    public GameObject confirmationPanel;

    // Start is called before the first frame update
    void Start()
    {
        //確認パネルを非表示
        confirmationPanel.SetActive(true);
    }

    public void confirmation()
    {
        //確認パネルを非表示
        confirmationPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
