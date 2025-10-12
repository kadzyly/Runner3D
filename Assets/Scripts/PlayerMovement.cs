using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(PlayerInputReader))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _forwardSpeed = 5f;
    [SerializeField] private float _horizontalSpeed = 5f;
    
    private Rigidbody _rigidbody;
    private PlayerInputReader _inputReader;
    private Vector2 _moveInput;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _inputReader = GetComponent<PlayerInputReader>();
    }

    private void OnEnable()
    {
        _inputReader.OnMove += OnMoveHandler;
    }
    
    private void OnDisable()
    {
        _inputReader.OnMove -= OnMoveHandler;
    }

    private void OnMoveHandler(Vector2 direction)
    {
        _moveInput = direction;
    }

    private void FixedUpdate()
    {
        Vector3 forwardMovement = transform.forward * _forwardSpeed;
        Vector3 horizontalMovement = transform.right * (_moveInput.normalized.x * _horizontalSpeed);
    
        // move
        _rigidbody.linearVelocity = new Vector3(
            forwardMovement.x + horizontalMovement.x,
            _rigidbody.linearVelocity.y,
            forwardMovement.z + horizontalMovement.z
        );
    }
}
