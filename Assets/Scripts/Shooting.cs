
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject spray;
    private GameObject instance;

    void Start()
    {
        spray = (GameObject)Resources.Load("spray");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
           
            if (Physics.Raycast(ray, out hit, 15f))
            {
                if (hit.collider.gameObject.tag == "corona")
                {
             
                    Vector3 hitPos = hit.point;        
                    instance = (GameObject)Instantiate(spray, hitPos, Quaternion.identity);
                    GameObject.Find("MainScripts").GetComponent<Init>().playCorona();
                    Destroy(instance, 1f);
                    Destroy(hit.collider.gameObject, 1f);
                    Init.score += 10;
                  
                }
      
            }
        }
    }
}
