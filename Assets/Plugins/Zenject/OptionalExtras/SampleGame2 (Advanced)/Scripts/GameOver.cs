using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public static GameOver instance = null;
    [SerializeField] private Button Retry, Continue;

    Animator Animator;
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

        Animator = GetComponent<Animator>();
        Retry.onClick.AddListener(UseRetry);
        Continue.onClick.AddListener(UseContinue);
    }


    public void OpenWindowGameOver()
    {
        Animator.SetTrigger("Open");
    }
    public void UseContinue()
    {
        Animator.SetTrigger("Close");
    }
    public void UseRetry()
    {
        Animator.SetTrigger("Close");
    }
}
