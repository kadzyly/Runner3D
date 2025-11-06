using UnityEngine;

public class SwitchObjectToParticles : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particlesPrefab;

    public void ActivateParticles()
    {
        Instantiate(_particlesPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
