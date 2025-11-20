using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    [SerializeField] GameObject _startMenu;
    [SerializeField] GameObject _restartMenu;
    [SerializeField] PlayerBehaviour _playerBehaviour;
    [SerializeField] private AudioSource _winSound;
    
    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
    }
    
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

    private void NotAllCoinsCollected()
    {
        _playerBehaviour.Lose();
        _restartMenu.SetActive(true);
    }

    private void FinishGame()
    {
        if (CoinManager.Instance.CoinCollectedInLevel >= CoinManager.Instance.MaxCoins)
        {
            WinGame();
        }
        else
        {
            NotAllCoinsCollected();
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    private void OnEnable()
    {
        Barrier.OnHitBarrier += LoseGame;
        Finish.OnFinish += FinishGame;
    }

    private void OnDisable()
    {
        Barrier.OnHitBarrier -= LoseGame;
        Finish.OnFinish -= FinishGame;
    }
}
