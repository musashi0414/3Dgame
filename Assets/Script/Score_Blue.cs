using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score_Blue : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText_blue;

    public static int score_blue;     //青スコア

    // Start is called before the first frame update
    void Start()
    {
        score_blue = 0; //スタートでスコアをリセット

        //// TextMeshProコンポーネントを取得
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
