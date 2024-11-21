using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    public Text ScoreText; // �X�R�A�� UI
    public Text highScoreText;// �n�C�X�R�A��\������
    private int score; // �X�R�A
    private int highScore;// �n�C�X�R�A
    private string highScoreKey = "highScore";// PlayerPrefs�ŕۑ����邽�߂̃L�[
    public int scorebox;

   

    // Start is called before the first frame update
    void Start()
    {
        Initialize();

        // UI ��������
        //score = 0;
        SetCountText();
    }

    private void OnTriggerEnter(Collider other)
    {
        // �X�R�A�����Z���܂�
        score = score + 3;
        //score += 3;
        //ScoreText.text = string.Format("�X�R�A:{0}", score);
        

        // UI �̕\�����X�V���܂�
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        // �X�R�A���n�C�X�R�A���傫�����
        if (highScore < score)
        {
            highScore = score;
        }

        // �X�R�A�E�n�C�X�R�A��\������
        scoreText.text = score.ToString();
        highScoreText.text = highScore.ToString();

        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    // �Q�[���J�n�O�̏�Ԃɖ߂�
    private void Initialize()
    {
        // �X�R�A��0�ɖ߂�
        score = 0;

        // �n�C�X�R�A���擾����B�ۑ�����ĂȂ����0���擾����B
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
    }

    // �|�C���g�̒ǉ�
    public void AddPoint(int point)
    {
        score = score + point;
    }

    // �n�C�X�R�A�̕ۑ�
    public void Save()
    {
        // �n�C�X�R�A��ۑ�����
        PlayerPrefs.SetInt(highScoreKey, highScore);
        PlayerPrefs.Save();

        // �Q�[���J�n�O�̏�Ԃɖ߂�
        Initialize();
    }

    // UI �̕\�����X�V����
    void SetCountText()
    {
        // �X�R�A�̕\�����X�V
        ScoreText.text = "Count: " + score.ToString();

        
    }
}
