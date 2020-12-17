using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgm : MonoBehaviour
{
    public static Bgm Instance;
    AudioSource bgm;
    bool bgmcheck = true;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
       
    }
    public void BgmStop()
    {
        if (Instance == null) bgm = gameObject.GetComponent<AudioSource>();
        else
        {
            bgm = Instance.GetComponent<AudioSource>();
        }
        if (bgmcheck)
        {
            bgm.enabled = false;
            bgmcheck = false;
        }
        else
        {
            bgm.enabled = true;
            bgmcheck = true;
        }
    }
   
}
