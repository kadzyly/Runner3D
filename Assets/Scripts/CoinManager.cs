using System;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance;
    private int _сoinCollectedInLevel = 0;
    private int _maxCoins = 0;
    
    [SerializeField] private TextMeshProUGUI _collectedCoinsUIText;
    [SerializeField] private TextMeshProUGUI _maxCoinsUIText;
    [SerializeField] private Transform _coinsParent;

    public int CoinCollectedInLevel => _сoinCollectedInLevel;
    public int MaxCoins => _maxCoins;

    
    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
    }

    private void Start()
    {
        _maxCoins = GetMaxCoins();
        _maxCoinsUIText.text = _maxCoins.ToString();
    }
    
    private void OnEnable()
    {
        Coin.OnCoinCollected += AddCoin;
    }

    private void OnDisable()
    {
        Coin.OnCoinCollected -= AddCoin;
    }
    
    private void AddCoin()
    {
        _сoinCollectedInLevel++;
        _collectedCoinsUIText.text = _сoinCollectedInLevel.ToString();
    }

    private int GetMaxCoins()
    {
        return _coinsParent.GetComponentsInChildren<Coin>().Length;
    }
}
