using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberofPoints : MonoBehaviour
{
    public int points;
    public bool isDelivered;

    private void Update()
    {
        if (isDelivered)
        {
            Destroy(gameObject);
        }
    }
}
