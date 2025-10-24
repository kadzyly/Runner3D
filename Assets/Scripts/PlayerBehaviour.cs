using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private Animator _animator;
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
    }

    public void Trip()
    {
        _animator.SetTrigger("IsTrip");
        Stop();
        
        _rigidbody.linearVelocity = Vector3.zero;
        _rigidbody.angularVelocity = Vector3.zero;
    }

    private void Stop()
    {
        _playerMovement.enabled = false;
    }
}
