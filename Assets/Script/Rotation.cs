using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    public Text ScoreText; // スコアの UI
    private int score; // スコア
    public static int scorebox;

    private void OnTriggerEnter(Collider other)
    {
        score += 3;
        ScoreText.text = string.Format("スコア:{0}", score);
        scorebox += score;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
