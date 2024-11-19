using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private Text ScoreCount;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        ScoreCount = GetComponentInChildren<Text>();
        ScoreCount.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        ScoreCount.text = score.ToString();
    }
}
