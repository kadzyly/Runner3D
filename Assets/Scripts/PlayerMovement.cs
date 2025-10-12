using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(PlayerInputReader))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _forwardSpeed = 5f;
    [SerializeField] private float _horizontalSpeed = 5f;
    [SerializeField] private Animator _animator;
    
    private Rigidbody _rigidbody;
    private PlayerInputReader _inputReader;
    private Vector2 _moveInput;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _inputReader = GetComponent<PlayerInputReader>();
    }

    private void Start()
    {
        _animator.SetBool("IsRun", true);
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
        Vector3 movement = CalculateMovement();
        ApplyMovement(movement);
    }

    private Vector3 CalculateMovement()
    {
        Vector3 forwardMovement = transform.forward * _forwardSpeed;
        Vector3 horizontalMovement = transform.right * (_moveInput.normalized.x * _horizontalSpeed);

        return forwardMovement + horizontalMovement;
    }
    
    private void ApplyMovement(Vector3 movement)
    {
        _rigidbody.linearVelocity = new Vector3(
            movement.x,
            _rigidbody.linearVelocity.y,
            movement.z
        );
    }
}
