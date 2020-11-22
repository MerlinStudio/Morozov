using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Zenject.SpaceFighter
{
    public class GameOver : MonoBehaviour
    {
        public static GameOver instance = null;

        [SerializeField] private Button Retry, Continue;

        public static bool isContinue;

        Animator Animator;
        void Start()
        {
            if (instance == null)
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
            isContinue = true;
        }
        public void UseRetry()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}