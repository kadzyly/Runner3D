using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private AudioSource _stepsSound;
    private Rigidbody _rigidbody;
    private PlayerMovement _playerMovement;

    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _rigidbody = GetComponent<Rigidbody>();
        Stop();
    }

    public void Play()
    {
        _playerMovement.enabled = true;
        _stepsSound.Play();
    }

    public void Trip()
    {
        _animator.SetTrigger("Trip");
        Stop();
        _rigidbody.linearVelocity = Vector3.zero;
        _rigidbody.angularVelocity = Vector3.zero;
    }

    public void Win()
    {
        _animator.SetTrigger("Dance");
        Stop();
        _rigidbody.linearVelocity = Vector3.zero;
        _rigidbody.angularVelocity = Vector3.zero;
    }

    private void Stop()
    {
        _playerMovement.enabled = false;
        _stepsSound.Stop();
    }
}
