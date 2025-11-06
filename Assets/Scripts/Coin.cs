using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private SwitchObjectToParticles _particles;
    public static event Action OnCoinCollected; 
    
    private void Awake()
    {
        _particles = GetComponent<SwitchObjectToParticles>();
    }
    
    private void Update()
    {
        transform.Rotate(0, 180 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        OnCoinCollected?.Invoke();
        _particles.ActivateParticles();
    }
}
