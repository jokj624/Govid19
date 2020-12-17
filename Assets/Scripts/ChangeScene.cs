using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeToPlay()
    {
        Init.score = 0;
        Init.time = 120;
        SceneManager.LoadScene("PlayScene");
    }
    public void ChangeToHow()
    {
        SceneManager.LoadScene("HowToScene");
    }
    public void ChangeToHome()
    {
        SceneManager.LoadScene("HomeScene");
    }
    public void ChangeToEnd()
    {
        SceneManager.LoadScene("End");
    }
}
