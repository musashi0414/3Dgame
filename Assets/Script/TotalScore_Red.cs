using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalScore_Red : MonoBehaviour
{
    TextMeshProUGUI scoreText_red;

    // Start is called before the first frame update
    void Start()
    {
        scoreText_red = GetComponent<TextMeshProUGUI>();     // TextMeshProコンポーネントを取得
    }

    // Update is called once per frame
    void Update()
    {
        scoreText_red.text = "RedPoint: " + Score_Red.score_red.ToString();   // 共有する変数をTextとして入れる
    }
}
