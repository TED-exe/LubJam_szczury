using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemToDeliver : MonoBehaviour
{
    private int points;
    [SerializeField] private SOFloat pointsTotal;

    private int childCount;
   
   private void OnTriggerEnter(Collider other)
   {
       if (other.tag == "Delivery") //test
       {
          childCount = transform.childCount;
          for (int i = 0; i < childCount;)
          {
             points += transform.GetChild(i).gameObject.GetComponent<NumberofPoints>().points;
             transform.GetChild(i).gameObject.GetComponent<NumberofPoints>().isDelivered = true;
          }
           
           pointsTotal.value += points;
           GameEventDelivery.current.ItemDestroy();
       }
   }
}
