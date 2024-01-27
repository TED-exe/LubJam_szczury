using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class DeliveryMechanic : MonoBehaviour
{
    [SerializeField] SOGameObject deliveryList;
    [SerializeField] SOGameObject deliverySpaceList;

    private int itemOnList;
    private int deliverySpace;
    private GameObject deliverySpacePlace;
    
    void Start()
    { 
        ItemSpawn();
        GameEventDelivery.current.onItemDestroy += ItemSpawn;
    }
    

    void ItemSpawn()
    {
        itemOnList = Random.Range(0, deliveryList.list.Count - 1);
        deliverySpace = Random.Range(0, deliverySpaceList.list.Count - 1); 
        deliverySpacePlace = deliverySpaceList.list[deliverySpace];
        deliverySpacePlace.SetActive(true);
        Instantiate(deliveryList.list[itemOnList]);
    }
}
