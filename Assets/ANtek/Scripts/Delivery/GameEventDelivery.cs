using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventDelivery : MonoBehaviour
{
    public static GameEventDelivery current;

    private void Awake()
    {
        current = this;
    }

    public event Action onItemDestroy;

    public void ItemDestroy()
    {
        if (onItemDestroy != null)
        {
            onItemDestroy();
        }
    }
}
