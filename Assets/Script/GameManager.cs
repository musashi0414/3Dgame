using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //スコア追加
    public GameObject scoreText;    //スコアテキスト
    public static int totalscore;   //合計スコア
    public int stageScore = 0;      //ステージスコア

    // Start is called before the first frame update
    void Start()
    {
        //スコア追加
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.gameState == "gameclear")
        {
            //スコア追加
            totalscore += stageScore;
            stageScore = 0;
            UpdateScore();//スコア更新
        }
        else if (PlayerController.gameState == "playing")
        {
            //スコア追加
            if (playCnt.score != 0)
            {
                stageScore += playCnt.score;
                playCnt.score = 0;
                UpdateScore();
            }

        }
    }

    //スコア追加
    void UpdateScore()
    {
        int score = stageScore + totalscore;
        scoreText.GetComponent<scoreText>().text = score.ToString();
    }
}
