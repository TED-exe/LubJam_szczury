using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public SO_OrderHolder spawnedObject;
    public GameObject spawnedObjectPrefab;
    [SerializeField] private Transform itemSpawnPlace;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(spawnedObjectPrefab != null)
            {
                Instantiate(spawnedObject.onTrayOrder, itemSpawnPlace.position, Quaternion.identity);
                Destroy(spawnedObjectPrefab);
                spawnedObject = null;
 
            }
        }
    }
}
