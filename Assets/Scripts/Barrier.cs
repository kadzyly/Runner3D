using System;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    private ParticleEffectHandler _particles;
    public static event Action OnHitBarrier;


    private void Start()
    {
        _particles = GetComponent<ParticleEffectHandler>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnHitBarrier?.Invoke();
            _particles.ActivateParticles();
        }
    }
}
