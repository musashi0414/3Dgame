using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score_Blue : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText_blue;

    private int score_blue;     //ê¬ÉXÉRÉA

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
        score_blue += 3;
        scoreText_blue.text = "SCORE: " + score_blue.ToString();
    }
}
