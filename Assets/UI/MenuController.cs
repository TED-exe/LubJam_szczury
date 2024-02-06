using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private Animation animator;

    void Start()
    {
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        animator.Play("CameraAnimation");
    }

    public void Exit()
    {
        Application.Quit();
    }
    
}
