using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaiterTrayControll : MonoBehaviour
{
    [SerializeField] private Transform midlePoint;
    [SerializeField] private Transform trayTransform;
    [SerializeField] private Transform holdTrayPosition;
    [SerializeField] private Transform player;
    [SerializeField] private float speedyGonzalez;

    private void FixedUpdate()
    {
        var localPosition = holdTrayPosition.localPosition;
        var globalPosition = transform.TransformPoint(localPosition);
        trayTransform.position = globalPosition;
        midlePoint.localPosition = Vector3.zero;
        trayTransform.rotation = transform.rotation;
    }
}
