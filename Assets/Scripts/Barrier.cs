using System;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    public static event Action OnHitBarrier; 
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnHitBarrier?.Invoke();
        }
    }
}
