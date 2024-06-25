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
    private int timeInt;
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private SOFloat points;
    [SerializeField] private PickUpObject pickUpObject;

    [SerializeField] GameObject loseScreen;
    
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
            Time.timeScale = 0f;
            loseScreen.SetActive(true);
        }
        
        timeInt = Mathf.FloorToInt(time);
        timeText.text = timeInt.ToString();
    }


    void ItemSpawn()
    {
        Debug.Log("1");
        time = maxtime;
        itemOnList = Random.Range(0, deliveryList.list.Count - 1);
        deliverySpace = Random.Range(0, DeliveryPlace.Count - 1); 
        deliverySpacePlace = DeliveryPlace[deliverySpace];
        deliverySpacePlace.SetActive(true);
        pickUpObject.spawnedObjectPrefab = Instantiate(deliveryList.list[itemOnList].pickUpOrder,gameObject.transform.position,gameObject.transform.rotation);
        pickUpObject.spawnedObject = deliveryList.list[itemOnList];
        
    }
}
