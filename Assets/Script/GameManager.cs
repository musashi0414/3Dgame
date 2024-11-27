using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] GameObject Mato;

    private int score;
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

       
        if (gameObject.tag == "Blue") // 青色かどうかのタグをチェック
        {
            score += 3;
            scoreText.text = "SCORE: " + score.ToString();
        }
        else if (gameObject.tag == "Red") // 赤色かどうかのタグをチェック
        {
            score += 5;
            scoreText.text = "SCORE: " + score.ToString();
        }
        else if (gameObject.tag == "Yellow") //黄色かどうかのタグをチェック
        {
            score += 10;
            scoreText.text = "SCORE: " + score.ToString();
        }
    }

    
}
