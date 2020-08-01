using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTriger : MonoBehaviour
{
    public GameManager manager;

    private void OnTriggerEnter()
    {
        manager.CompleteLevel();
    }

    
}
