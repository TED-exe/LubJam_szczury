using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayGame : MonoBehaviour
{
    [SerializeField] private string trigerText;
    [SerializeField] private Animator animator;

    public void AnimatorOn()
    {
        Time.timeScale = 1; 
        animator.SetTrigger("Trigger");
    }
}
