using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(PlayerInputReader))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private RoadInfo _roadInfo;
    [SerializeField] private Animator _animator;
    
    [SerializeField] private float _forwardSpeed = 5f;
    [SerializeField] private float _horizontalSpeed = 5f;
    private const float HorizontalMargin = 0.6f;
    
    private Rigidbody _rigidbody;
    private PlayerInputReader _inputReader;
    private Vector2 _moveInput;
    
    private float _horizontalLimit;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _inputReader = GetComponent<PlayerInputReader>();
    }

    private void Start()
    {
        _animator.SetBool("IsRun", true);
        _roadInfo = _roadInfo.GetComponent<RoadInfo>();
        _horizontalLimit = _roadInfo.Width / 2f - HorizontalMargin;
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
        Vector3 velocity = movement;
        velocity.y = _rigidbody.linearVelocity.y;

        ClampHorizontalVelocity(ref velocity);

        _rigidbody.linearVelocity = velocity;
    }

    private void ClampHorizontalVelocity(ref Vector3 velocity)
    {
        float nextX = transform.position.x + velocity.x * Time.fixedDeltaTime;

        if (nextX > _horizontalLimit || nextX < -_horizontalLimit)
        {
            velocity.x = 0f;
        }
    }
}
