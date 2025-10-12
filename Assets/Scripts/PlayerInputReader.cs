using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputReader : MonoBehaviour
{
    private PlayerControl _inputActions;
    
    public event Action<Vector2> OnMove;


    private void Awake()
    {
        _inputActions = new PlayerControl();
    }

    private void OnEnable()
    {
        _inputActions.Enable();
        _inputActions.Gameplay.Move.performed += HandleMove;
        _inputActions.Gameplay.Move.canceled += HandleMove;
    }
    
    private void OnDisable()
    {
        _inputActions.Gameplay.Move.performed -= HandleMove;
        _inputActions.Gameplay.Move.canceled -= HandleMove;
        _inputActions.Disable();
    }

    private void HandleMove(InputAction.CallbackContext context)
    {
        OnMove?.Invoke(context.ReadValue<Vector2>());
    }
}
