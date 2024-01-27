using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RatController : MonoBehaviour
{
    [SerializeField] private Controller controller;
    private Vector2 ratMovement;

    private float speed;

    [SerializeField] private float minSpeed;

    [SerializeField] private float maxSpeed;

    private Rigidbody rigidbody;
    // Start is called before the first frame update
    
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        controller = new Controller();
        controller.Fucking_Controller.Movement_FuckingRat.performed += cntxt => ratMovement =  cntxt.ReadValue<Vector2>();
        controller.Fucking_Controller.Movement_FuckingRat.canceled += cntxt => ratMovement = Vector2.zero;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (ratMovement.magnitude)
        {
            case 0:
                speed = 0;
                break;
            case < 0.5f:
                speed = minSpeed;
                break;
            case > 0.5f:
                speed = maxSpeed;
                break;
        }
        Vector3 m = new Vector3(speed, 0, 0);
        Vector3 rotation = new Vector3(ratMovement.x, ratMovement.y, 0);
        rigidbody.AddForce(m * 0.0005f,ForceMode.VelocityChange);
        transform.Rotate(rotation * Time.deltaTime);
    //     transform.forward = m;
    //     GetComponent<Rigidbody>().velocity = m;
    }
    private void OnEnable()
    {
        controller.Fucking_Controller.Enable();
    }
    private void OnDisable()
    {
        controller.Fucking_Controller.Disable();
    }
}
