using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static event Action OnCoinCollected; 
    
    private void Update()
    {
        transform.Rotate(0, 180 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        OnCoinCollected?.Invoke();
        Destroy(gameObject);
    }
}
