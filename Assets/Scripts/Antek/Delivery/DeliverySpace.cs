using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeliverySpace : MonoBehaviour
{
    private void Awake()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dish")
        {
            gameObject.SetActive(false);
        }
    }
}
