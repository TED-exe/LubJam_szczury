using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class DeliveryMechanic : MonoBehaviour
{
    [SerializeField] SOGameObject deliveryList;
    [SerializeField] private List<GameObject> DeliveryPlace = new List<GameObject>();

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
        deliverySpace = Random.Range(0, DeliveryPlace.Count - 1); 
        deliverySpacePlace = DeliveryPlace[deliverySpace];
        deliverySpacePlace.SetActive(true);
        Instantiate(deliveryList.list[itemOnList],gameObject.transform.position,gameObject.transform.rotation);
    }
}
