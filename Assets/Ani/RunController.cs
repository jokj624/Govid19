using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunController : MonoBehaviour
{

    public Animator animator;
    public Rigidbody rigidbody;

    private float h; //수평 방향키
    private float v; // 수직 방향키
    private float moveX;
    private float moveZ;
    private float speedH = 15f;
    private float speedZ = 60f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
     
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        animator.SetFloat("Direction", h);
        animator.SetFloat("Move", v); 

        moveX = h * speedH * Time.deltaTime;
        moveZ = v * speedZ * Time.deltaTime;

        if (moveZ <= 0)  //뒤로 이동할 땐 옆으로 못하게
        {
            moveX = 0;
        }
        rigidbody.velocity = new Vector3(moveX, 0, moveZ);

    }
}