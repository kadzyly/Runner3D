using System;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    private SwitchObjectToParticles _particles;
    public static event Action OnHitBarrier;


    private void Start()
    {
        _particles = GetComponent<SwitchObjectToParticles>();
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
