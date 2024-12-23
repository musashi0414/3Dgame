using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score_Yellow : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText_yellow;

    public static int score_yellow;   //黄スコア

    // Start is called before the first frame update
    void Start()
    {
        score_yellow = 0; //スタートでスコアをリセット
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score_yellow += 5;
        scoreText_yellow.text = "SCORE: " + score_yellow.ToString();
    }
}
