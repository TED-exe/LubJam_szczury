using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnOnCamera : MonoBehaviour
{w
   [SerializeField] private GameObject player;
   [SerializeField] private GameObject spawnPoint;
   public void PlayerSpawn()
   {
      Instantiate(player, spawnPoint.transform.position, spawnPoint.transform.rotation);
   }
}
