using System;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    private int _сoinsCollectedInLevel = 0;

    [SerializeField] private TextMeshProUGUI _text;
    
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
        _сoinsCollectedInLevel++;
        _text.text = _сoinsCollectedInLevel.ToString();
    }
}
