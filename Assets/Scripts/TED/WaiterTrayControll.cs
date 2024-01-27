using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaiterTrayControll : MonoBehaviour
{
    [SerializeField] private Transform trayTransform;
    [SerializeField] private Transform holdTrayPosition;

    private void FixedUpdate()
    {
        trayTransform.position = Vector3.Lerp(trayTransform.position, holdTrayPosition.position, 10f);
        trayTransform.rotation = transform.rotation;
    }
}
