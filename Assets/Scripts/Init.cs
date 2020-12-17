using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Init : MonoBehaviour
{
    public static Text timetxt, scoretxt;
    public static int time=120, score=0;
    public AudioSource audio1;
    int f;

    void Start()
    {
      
        timetxt = GameObject.Find("time").GetComponent<Text>();
        scoretxt = GameObject.Find("score").GetComponent<Text>();
        f = 0;
    }

    void FixedUpdate()
    {
        f++;
        if (f % 50 == 0)
        {
            time--;
            
        }

        setTime();
        setScore();
    }
    public static void setTime()
    {
        timetxt.text = "TIME : " + time.ToString() + "s";
        if(time == 0)
        {
            GameOver();
        }
    }
    public static void setScore()
    {
        scoretxt.text = "SCORE : " + score.ToString();
    }
    public void playCorona()
    {
        audio1.Play();
    }
    public static void GameOver()
    {
        SceneManager.LoadScene("End");
    }
}
