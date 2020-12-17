using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateItems : MonoBehaviour
{
    public GameObject[] item = new GameObject[2];
    private GameObject instance;
    public Vector3 pos;
    void Start()
    {
        item[0] = (GameObject)Resources.Load("sana");// load a prefab for enemy
        item[1] = (GameObject)Resources.Load("mask");
        InvokeRepeating("Items", 10.0f, 11.0f); 
    }
    void Items()
    {
        float x = Random.Range(-9f, 14f);
        float z = Random.Range(-6f, 12f);
        int idx = Random.Range(0, 2);
        instance = (GameObject)Instantiate(item[idx], new Vector3(x, 0f, z), Quaternion.Euler(0, 120, 0));

    }
}
