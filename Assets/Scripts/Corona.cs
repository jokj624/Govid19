using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corona : MonoBehaviour
{
    public GameObject corona;
    private GameObject instance;
    public Vector3 pos;
    private float moveSpeed = 2;
    void Start()
    {
        corona = (GameObject)Resources.Load("corona");// load a prefab for enemy
        InvokeRepeating("CreateCorona", 3.0f, 3.0f); // (function, after 1 sec, every 1 sec)
    }
    void CreateCorona()
    {
        float x = Random.Range(-9f, 14f);
        float y = Random.Range(0.5f, 1.5f);
        float z = Random.Range(-6f, 12f);
        instance = (GameObject)Instantiate(corona, new Vector3(x , y, z), Quaternion.Euler(0, 120, 0));
       
    }
}
