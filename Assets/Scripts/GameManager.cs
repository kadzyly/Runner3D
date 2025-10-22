using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _startMenu;
    [SerializeField] PlayerBehaviour _playerBehaviour;
    
    public void StartGame()
    {
        _startMenu.SetActive(false);
        _playerBehaviour.Play();
    }
}
