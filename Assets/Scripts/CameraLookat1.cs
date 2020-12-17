using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookat1 : MonoBehaviour
{
    private Transform cam;
    void Start()
    {
        cam = Camera.main.transform;
    }

    void Update()
    {
        transform.rotation = Quaternion.Euler(cam.rotation.x, cam.rotation.y, cam.rotation.z);
    }
}
