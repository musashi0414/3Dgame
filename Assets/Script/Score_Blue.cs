using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score_Blue : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText_blue;

    public static int score_blue;     //�X�R�A

    // Start is called before the first frame update
    void Start()
    {
        score_blue = 0; //�X�^�[�g�ŃX�R�A�����Z�b�g

        //// TextMeshPro�R���|�[�l���g���擾
        //scoreText_blue = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score_blue += 3;
        scoreText_blue.text = "SCORE: " + score_blue.ToString();
    }
}
