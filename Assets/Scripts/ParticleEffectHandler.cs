using System;
using UnityEngine;

public class ParticleEffectHandler : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particle;
    [SerializeField] private MeshRenderer _meshRenderer;

    private bool _isActivated = false;
    
    public event Action OnParticlesDeactivated; 
    

    public void ActivateParticles()
    {
        _particle.gameObject.SetActive(true);
        _particle.Play();
        _isActivated = true;
        
        _meshRenderer.enabled = false;
    }

    private void FixedUpdate()
    {
        if (_isActivated && !_particle.IsAlive())
        {
            _isActivated = false;
            OnParticlesDeactivated?.Invoke();
        }
    }
}
