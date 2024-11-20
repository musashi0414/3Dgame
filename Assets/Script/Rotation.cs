using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    public Text ScoreText; // �X�R�A�� UI
    private int score; // �X�R�A
    public static int scorebox;

    private void OnTriggerEnter(Collider other)
    {
        score += 3;
        ScoreText.text = string.Format("�X�R�A:{0}", score);
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
