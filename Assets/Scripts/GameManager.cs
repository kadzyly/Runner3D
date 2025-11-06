using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _startMenu;
    [SerializeField] GameObject _restartMenu;
    [SerializeField] PlayerBehaviour _playerBehaviour;
    [SerializeField] private AudioSource _winSound;
    
    public void StartGame()
    {
        _startMenu.SetActive(false);
        _restartMenu.SetActive(false);
        _playerBehaviour.Play();
    }

    private void LoseGame()
    {
        _playerBehaviour.Trip();
        _restartMenu.SetActive(true);
    }

    private void WinGame()
    {
        _playerBehaviour.Win();
        _winSound.Play();
        _restartMenu.SetActive(true);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    private void OnEnable()
    {
        Barrier.OnHitBarrier += LoseGame;
        Finish.OnFinish += WinGame;
    }

    private void OnDisable()
    {
        Barrier.OnHitBarrier -= LoseGame;
        Finish.OnFinish -= WinGame;
    }
}
