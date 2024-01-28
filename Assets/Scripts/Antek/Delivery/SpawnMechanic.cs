using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class DeliveryMechanic : MonoBehaviour
{
    [SerializeField] SOGameObject deliveryList;
    [SerializeField] private List<GameObject> DeliveryPlace = new List<GameObject>();

    private int itemOnList;
    private int deliverySpace;
    private GameObject deliverySpacePlace;
    [SerializeField] float maxtime;
    private float time;
    [SerializeField] private TextMeshProUGUI timeText;
    
    void Start()
    { 
        ItemSpawn();
        GameEventDelivery.current.onItemDestroy += ItemSpawn;
    }

    private void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            Debug.Log("Lose");
        }

        timeText.text = time.ToString();
    }


    void ItemSpawn()
    {
        time = maxtime;
        itemOnList = Random.Range(0, deliveryList.list.Count - 1);
        deliverySpace = Random.Range(0, DeliveryPlace.Count - 1); 
        deliverySpacePlace = DeliveryPlace[deliverySpace];
        deliverySpacePlace.SetActive(true);
        Instantiate(deliveryList.list[itemOnList],gameObject.transform.position,gameObject.transform.rotation);
    }
}
