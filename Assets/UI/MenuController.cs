using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private Animation animator;

    public void StartGame()
    {
        animator.Play("CameraAnimation");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
