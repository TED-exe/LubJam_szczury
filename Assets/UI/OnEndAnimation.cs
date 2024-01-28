using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEndAnimation : MonoBehaviour
{
    [SerializeField] private GameObject MenuToOff;
    [SerializeField] private GameObject CameraToOn;
    [SerializeField] private GameObject PlayerToOn;
    [SerializeField] private Camera CameraToOff;
    [SerializeField] private GameObject Timer;
    public void EndAnimation()
    {
        Timer.SetActive(true);
        PlayerToOn.SetActive(true);
        CameraToOn.SetActive(true);
        CameraToOff.enabled = false;
    }
    public void StartAnimation()
    {
        MenuToOff.SetActive(false);
    }
}
