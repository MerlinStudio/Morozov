using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Zenject.SpaceFighter;

public class EnemyShutdown : MonoBehaviour
{
    void Update()
    {
        if(GameOver.isContinue)
        {
            gameObject.SetActive(false);
        }
    }
}
