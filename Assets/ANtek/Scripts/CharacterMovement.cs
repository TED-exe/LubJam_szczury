using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Controller controller;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;

    [SerializeField] private bool isFuckingRat;
    private CharacterController characterController;
    private Rigidbody rb;
    private Vector2 playerDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        controller = new Controller();
        controller.Fucking_Controller.Enable();

    }
    private void LateUpdate()
    {
        if (isFuckingRat)
            playerDirection = controller.Fucking_Controller.Movement_FuckingRat.ReadValue<Vector2>();
        else
            playerDirection = controller.Fucking_Controller.Movement_Waiter.ReadValue<Vector2>();

        if (playerDirection != Vector2.zero)
        {
            Vector3 inputDirection = new Vector3(playerDirection.x, 0f, playerDirection.y);
            Quaternion targetRotation = Quaternion.LookRotation(inputDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * playerDirection.magnitude * Time.fixedDeltaTime);
        }

        //movement
        Vector3 moveDirection = transform.forward * moveSpeed * playerDirection.magnitude;
        rb.velocity = moveDirection;


        Vector3 inputDirection_debug = new Vector3(playerDirection.x, 0f, playerDirection.y);
        Debug.DrawRay(transform.position, transform.forward, Color.green);
        Debug.DrawRay(transform.position, inputDirection_debug, Color.red);
    }
}


































