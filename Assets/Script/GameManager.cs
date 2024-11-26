using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //�X�R�A�ǉ�
    public GameObject scoreText;    //�X�R�A�e�L�X�g
    public static int totalscore;   //���v�X�R�A
    public int stageScore = 0;      //�X�e�[�W�X�R�A

    // Start is called before the first frame update
    void Start()
    {
        //�X�R�A�ǉ�
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.gameState == "gameclear")
        {
            //�X�R�A�ǉ�
            totalscore += stageScore;
            stageScore = 0;
            UpdateScore();//�X�R�A�X�V
        }
        else if (PlayerController.gameState == "playing")
        {
            //�X�R�A�ǉ�
            if (playCnt.score != 0)
            {
                stageScore += playCnt.score;
                playCnt.score = 0;
                UpdateScore();
            }

        }
    }

    //�X�R�A�ǉ�
    void UpdateScore()
    {
        int score = stageScore + totalscore;
        scoreText.GetComponent<scoreText>().text = score.ToString();
    }
}
