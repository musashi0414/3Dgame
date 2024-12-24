using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RankYellow : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI rankYellow;

    // Start is called before the first frame update
    void Start()
    {
        rankYellow.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Score_Yellow.score_yellow == 0)
        {
            rankYellow.text = "NoRank:  good luck! You can do it!";
        }

        if (Score_Yellow.score_yellow >= 5)
        {
            rankYellow.text = "Rank:C  Nice!";
        }

        if (Score_Yellow.score_yellow >= 10)
        {
            rankYellow.text = "Rank:B  Great!";
        }

        if (Score_Yellow.score_yellow >= 15)
        {
            rankYellow.text = "Rank:A  Very Good!";
        }

        if (Score_Yellow.score_yellow == 20)
        {
            rankYellow.text = "Rank:S  Congratulations!!";
        }
    }
}
