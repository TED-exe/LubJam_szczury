using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectController : MonoBehaviour
{
    [SerializeField] private LayerMask trayLayer;
    [SerializeField, Range(0.001f,100f)] private float velMultiplayer;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit,(transform.localScale.y * 0.5f) + 0.05f, trayLayer))
        { 
            TrayController controll = hit.transform.GetComponentInParent<TrayController>();
            {
                transform.SetParent(controll.itemHolder);
            }
        }
        else
        {
            transform.SetParent(null);
        }

        if(transform.parent != null)
        {
            TrayController controller = transform.parent.GetComponentInParent<TrayController>();
            var objVel = new Vector3 (controller.movement.playerDirection.x,0,controller.movement.playerDirection.y) * -1 * velMultiplayer;
            rb.AddForce(objVel);
        }
    }
}
