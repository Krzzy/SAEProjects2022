using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Movement_2D : MonoBehaviour
{
    public float Speed;

    private float inputHorizontal;
    private Rigidbody2D rb;
    pri+vate void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //saving the horizontalInput 
        inputHorizontal = Input.GetAxisRaw("Horizontal");    
    }

    private void FixedUpdate()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {

    }
}
