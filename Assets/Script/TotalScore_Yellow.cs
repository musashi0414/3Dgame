using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalScore_Yellow : MonoBehaviour
{
    TextMeshProUGUI scoreText_yellow;

    // Start is called before the first frame update
    void Start()
    {
        scoreText_yellow = GetComponent<TextMeshProUGUI>();     // TextMeshPro�R���|�[�l���g���擾
    }

    // Update is called once per frame
    void Update()
    {
        scoreText_yellow.text = "YellowPoint: " + Score_Yellow.score_yellow.ToString();   // ���L����ϐ���Text�Ƃ��ē����
    }
}
