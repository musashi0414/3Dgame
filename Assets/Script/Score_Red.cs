using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score_Red : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText_red;

    public static int score_red;      //赤スコア

    // Start is called before the first frame update
    void Start()
    {
        score_red = 0; //スタートでスコアをリセット
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score_red += 10;
        scoreText_red.text = "SCORE: " + score_red.ToString();
    }
}
