using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score_Red : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText_red;

    private int score_red;      //ê‘ÉXÉRÉA

    // Start is called before the first frame update
    void Start()
    {
        
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
