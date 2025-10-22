using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private PlayerMovement _playerMovement;

    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _playerMovement.enabled = false;
    }

    public void Play()
    {
        _playerMovement.enabled = true;
    }
        
}
