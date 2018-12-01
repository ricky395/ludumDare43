using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CharacterMovement : MonoBehaviour
{

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    private bool facingRight;

    private Transform tr;

    void Start()
    {
        tr = transform;

        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        //facingRight = (Input.GetAxis("Horizontal") >= 0) ? true : false;

        //if (!facingRight)
        //{
        //    tr.localScale = new Vector3(-tr.localScale.x, 1, 1);
        //}

        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);

        controller.Move(moveDirection * Time.deltaTime);
    }
}
