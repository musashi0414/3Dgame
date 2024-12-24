using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalScore_Blue : MonoBehaviour
{
    TextMeshProUGUI scoreText_blue;

    // Start is called before the first frame update
    void Start()
    {
        scoreText_blue = GetComponent<TextMeshProUGUI>();       // TextMeshProコンポーネントを取得       
    }

    // Update is called once per frame
    void Update()
    {
        scoreText_blue.text = "BluePoint: " + Score_Blue.score_blue.ToString();       // 共有する変数をTextとして入れる
    }
}
