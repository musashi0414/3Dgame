using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RankBlue : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI rankBlue;

    // Start is called before the first frame update
    void Start()
    {
        rankBlue.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Score_Blue.score_blue < 10)
        {
            rankBlue.text = "NoRank:  good luck! You can do it!";
        }

        if (Score_Blue.score_blue >= 10)
        {
            rankBlue.text = "Rank:C  Nice!";
        }

        if (Score_Blue.score_blue >= 30)
        {
            rankBlue.text = "Rank:B  Great!";
        }

        if (Score_Blue.score_blue >= 50)
        {
            rankBlue.text = "Rank:A  Very Good!";
        }

        if (Score_Blue.score_blue == 60)
        {
            rankBlue.text = "Rank:S  Congratulations!!";
        }
    }
}
