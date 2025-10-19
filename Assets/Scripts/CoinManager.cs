using System;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    private int _сoinsCollectedInLevel = 0;
    
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
    }
}
