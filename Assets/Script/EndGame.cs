using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject confirmationPanel;

    // Start is called before the first frame update
    private void Start()
    {
        //�m�F�p�l�����\��
        confirmationPanel.SetActive(false);
    }

    //�m�F
    public void confirmation()
    {
        confirmationPanel.SetActive(true);
    }

    //�Q�[���I��
    public void Endgame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
#else
    Application.Quit();//�Q�[���v���C�I��
#endif
    }
}
