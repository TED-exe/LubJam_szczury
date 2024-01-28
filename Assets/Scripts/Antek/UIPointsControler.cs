using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIPointsControler : MonoBehaviour
{
    [SerializeField] private SOFloat totalPoints;
    [SerializeField] private SOFloat gainedPoints;
    [SerializeField] private TextMeshProUGUI totalPointsText;

    [SerializeField] private GameObject spawnPointOfPopUp;

    [SerializeField] private GameObject PopUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalPointsText.text = totalPoints.value.ToString();
        if (gainedPoints.value != 0)
        {
            Instantiate(PopUp, spawnPointOfPopUp.transform);
            gainedPoints.value = 0;
        }
    }
}
