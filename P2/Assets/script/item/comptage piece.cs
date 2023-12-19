using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comptagepiece : MonoBehaviour
{
    [SerializeField] private List<coletible_coin> _coins;

    public int collectedCoins = 0;
    public int remainingCoins;
    public int totalcoin;

    
    public void CoinCollected()
    {
        collectedCoins++;
        remainingCoins = _coins.Count - collectedCoins;
        totalcoin = _coins.Count;

    }
}
