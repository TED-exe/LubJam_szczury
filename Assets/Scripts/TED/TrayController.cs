using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayController : MonoBehaviour
{
    [SerializeField] private Transform[] allControllPoint;
    [SerializeField] private LayerMask whatIsGround;
    public Rigidbody trayRigidbody;
    [SerializeField] private GameObject tray;
    public CharacterMovement movement;
    public Transform itemHolder;

    [Header("suspesion Settings")]
    [SerializeField] private float springLeanght;
    [SerializeField] private float springStrenght;
    [SerializeField] private float springDamper;

    private void FixedUpdate()
    {
        for (int i = 0; i < allControllPoint.Length; i++)
        {

            if (CheckTireTouchGround(allControllPoint[i]).succes)
            {
                SuspesionCalculate(allControllPoint[i], CheckTireTouchGround(allControllPoint[i]).hit);

            }
            else
            {
                Debug.DrawLine(allControllPoint[i].position, allControllPoint[i].position + Vector3.down * springLeanght, Color.white);
            }
        }

        Quaternion currentRotation = transform.rotation;
        tray.transform.rotation = currentRotation;
    }

    private void SuspesionCalculate(Transform selectedTireTransform, RaycastHit hitPlace)
    {
        Vector3 springDir = selectedTireTransform.up;
        Vector3 tireWorldVel = trayRigidbody.GetPointVelocity(selectedTireTransform.position);
        
        float offset = springLeanght - hitPlace.distance;
        float vel = Vector3.Dot(springDir, tireWorldVel);
        float force = (offset * springStrenght) - (vel * springDamper);

        trayRigidbody.AddForceAtPosition(springDir * force, selectedTireTransform.position);

        Debug.DrawLine(selectedTireTransform.position, selectedTireTransform.position + Vector3.down * hitPlace.distance, Color.red);
        Debug.DrawLine(selectedTireTransform.position, selectedTireTransform.position + Vector3.up * force, Color.green);
    }

    private (bool succes, RaycastHit hit) CheckTireTouchGround(Transform selectedTireTransform)
    {
        if (Physics.Raycast(selectedTireTransform.position, Vector3.down, out var hitPoint, springLeanght, whatIsGround))
            return (succes: true, hit: hitPoint);
        else
            return (succes: false, hit: hitPoint);
    }
}
