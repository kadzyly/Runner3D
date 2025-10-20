using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _startMenu;
    
    public void StartGame()
    {
        _startMenu.SetActive(false);
    }
}
