using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemToDeliver : MonoBehaviour
{
    private int points;
    [SerializeField] private SOFloat pointsTotal;
    [SerializeField] private SOFloat pointsGained;

    private int childCount;
    [SerializeField] private GameObject itemHolder;
    private List<GameObject> childs = new List<GameObject>();
   
   private void OnTriggerEnter(Collider other)
   {
       if (other.tag == "Delivery") //test
       {
          childCount = itemHolder.transform.childCount;
          for (int i = 0; i < childCount; i++)
          {
              childs.Add(itemHolder.transform.GetChild(i).gameObject);
          }

          for (int i = 0; i < childs.Count; i++)
          {
              points += childs[i].GetComponent<NumberofPoints>().points;
              childs[i].GetComponent<NumberofPoints>().isDelivered = true;
          }
          
           childs.Clear();
           pointsGained.value = points;
           pointsTotal.value += points;
           points = 0;
           GameEventDelivery.current.ItemDestroy();
       }
   }
}
