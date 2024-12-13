using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText_blue;
    [SerializeField] TextMeshProUGUI scoreText_yellow;
    [SerializeField] TextMeshProUGUI scoreText_red;

    private int score_blue;     //�X�R�A
    private int score_yellow;   //���X�R�A
    private int score_red;      //�ԃX�R�A
    //private float time;
    //private int vecX;



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

        score_yellow += 5;
        scoreText_yellow.text = "SCORE: " + score_yellow.ToString();

        score_red += 10;
        scoreText_red.text = "SCORE: " + score_red.ToString();

        //if (gameObject.tag == "Blue") // �F���ǂ����̃^�O���`�F�b�N
        //{

        //}
        //else if (gameObject.tag == "Red") // �ԐF���ǂ����̃^�O���`�F�b�N
        //{
        //    score += 5;
        //    scoreText.text = "SCORE: " + score.ToString();
        //}
        //else if (gameObject.tag == "Yellow") //���F���ǂ����̃^�O���`�F�b�N
        //{
        //    score += 10;
        //    scoreText.text = "SCORE: " + score.ToString();
        //}
    }


}
