using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Controller controller;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;

    [SerializeField] private bool isFuckingRat;
    [SerializeField] private Transform waiterTransform;
    private Rigidbody rb;
    public Vector2 playerDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        controller = new Controller();
        controller.Fucking_Controller.Enable();

    }
    private void FixedUpdate()
    {
        if (isFuckingRat)
        {
            playerDirection = controller.Fucking_Controller.Movement_FuckingRat.ReadValue<Vector2>();
            var horizontal = playerDirection.y;//x
            var vertical = playerDirection.x;//z

            var moveDirection = waiterTransform.forward * horizontal + waiterTransform.right * vertical;
            if (playerDirection != Vector2.zero)
            {
                Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);
            }

            rb.velocity = moveDirection * moveSpeed;
            Debug.DrawRay(transform.position, moveDirection, Color.red);

        }
        else
        {
            playerDirection = controller.Fucking_Controller.Movement_Waiter.ReadValue<Vector2>();
            Vector3 inputDirection = new Vector3(playerDirection.x, 0f, playerDirection.y);
            Quaternion targetRotation = Quaternion.LookRotation(inputDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * playerDirection.magnitude * Time.fixedDeltaTime);


            //movement
            Quaternion rotation = Quaternion.Euler(transform.forward);
            Vector3 moveDirection = rotation * (transform.forward * moveSpeed * playerDirection.magnitude);
            rb.velocity = moveDirection;

            Debug.DrawRay(transform.position, moveDirection, Color.blue);
            Debug.Log(playerDirection);
            Vector3 inputDirection_debug = new Vector3(playerDirection.x, 0f, playerDirection.y);
            Debug.DrawRay(transform.position, transform.forward, Color.green);
            Debug.DrawRay(transform.position, inputDirection_debug, Color.red);
        }


    }
}


































