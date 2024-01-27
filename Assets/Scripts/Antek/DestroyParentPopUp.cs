using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DestroyParentPopUp : MonoBehaviour
{
    [SerializeField] SOFloat pointsGained;
    private void Awake()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = pointsGained.value.ToString();
    }

    public void DestroyParent()
    {
        GameObject parent = gameObject.transform.parent.gameObject;
        Destroy(parent);
    }
}
