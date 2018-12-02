using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CharacterMovement : MonoBehaviour
{

    [SerializeField] private  float speed     = 6.0f  ;
    [SerializeField] private  float jumpSpeed = 8.0f  ;
    [SerializeField] private  float gravity   = 20.0f ;
    [SerializeField] private  float angularSpeed = 10f;


    private Vector3 moveDirection = Vector3.zero;

    private CharacterController controller;

    private bool facingRight;

    public Transform body;
    

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        facingRight = (Input.GetAxis("Horizontal") > 0) ? true : false;

        if (Input.GetAxis("Horizontal") == 0) { /* NEPE*/ }
        else if (!facingRight)
        {
            body.rotation = Quaternion.Lerp(body.rotation, Quaternion.Euler(0, -180, 0), Time.deltaTime * angularSpeed);
            // body.localRotation = Quaternion.Euler( 0, 180 , 0);   << Cutre
        }
        else
        {
            body.rotation = Quaternion.Lerp(body.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime*angularSpeed);
            //  body.localRotation = Quaternion.Euler(0, 0, 0);      << Cutre
        }

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
