using UnityEngine;
using System;

public class Finish : MonoBehaviour
{
    public static event Action OnFinish; 
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnFinish?.Invoke();
        }
    }
}
