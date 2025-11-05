using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private ParticleEffectHandler _particles;
    public static event Action OnCoinCollected; 
    
    private void Awake()
    {
        _particles = GetComponent<ParticleEffectHandler>();
    }
    
    private void Update()
    {
        transform.Rotate(0, 180 * Time.deltaTime, 0);
    }

    private void OnEnable()
    {
        _particles.OnParticlesDeactivated += DeleteCoin;
    }
    
    private void OnDisable()
    {
        _particles.OnParticlesDeactivated -= DeleteCoin;
    }

    private void OnTriggerEnter(Collider other)
    {
        OnCoinCollected?.Invoke();
        _particles.ActivateParticles();
    }

    private void DeleteCoin()
    {
        Destroy(gameObject);
    }
}
