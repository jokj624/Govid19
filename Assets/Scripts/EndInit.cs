using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndInit : MonoBehaviour
{
    public static Text score_text;
    int sc = 0;
    void Start()
    {
        score_text = GameObject.Find("score_text").GetComponent<Text>();
        sc = Init.score;
        score_text.text = "" + sc.ToString();
    }

    
}
