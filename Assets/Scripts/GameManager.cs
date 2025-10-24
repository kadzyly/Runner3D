using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _startMenu;
    [SerializeField] GameObject _restartMenu;
    [SerializeField] PlayerBehaviour _playerBehaviour;
    
    public void StartGame()
    {
        _startMenu.SetActive(false);
        _restartMenu.SetActive(false);
        _playerBehaviour.Play();
    }

    private void LoseGame()
    {
        // _playerBehaviour.Stop();
        _playerBehaviour.Trip();
        _restartMenu.SetActive(true);
        // Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        // Time.timeScale = 1f;
        _restartMenu.SetActive(false);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // _playerBehaviour.Play();
    }
    
    private void OnEnable()
    {
        Barrier.OnHitBarrier += LoseGame;
    }

    private void OnDisable()
    {
        Barrier.OnHitBarrier -= LoseGame;
    }
}
