using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit_scene : MonoBehaviour
{
    public void ChangeToExit()
    {
        Init.time = 120;
        Init.score = 0;
        SceneManager.LoadScene("start");
    }
}
