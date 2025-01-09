using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RankRed : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI rankRed;

    // Start is called before the first frame update
    void Start()
    {
        rankRed.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Score_Red.score_red == 0)
        {
            rankRed.text = "Rank:B  Nice  Try!";
        }

        if (Score_Red.score_red >= 10)
        {
            rankRed.text = "Rank:A  Great!";
        }

        if (Score_Red.score_red == 20)
        {
            rankRed.text = "Rank:S  Congratulations!!";
        }
    }
}
