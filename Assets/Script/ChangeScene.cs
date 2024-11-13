using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string MainScene;
    public string ClearScene;
    public string TitleScene;
    public string StageSelect;
    public string OperationScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Load()
    {
        SceneManager.LoadScene(MainScene);
        SceneManager.LoadScene(ClearScene);
        SceneManager.LoadScene(TitleScene);
        SceneManager.LoadScene(StageSelect);
        SceneManager.LoadScene(OperationScene);
    }
}
