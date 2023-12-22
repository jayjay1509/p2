using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class coin_manager : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI HighscoreText;
    private comptagepiece _Cp;

    
    void Start()
    {
        _Cp = FindObjectOfType<comptagepiece>();
    }

    // Update is called once per frame
    void Update()
    {
        
        int score   = _Cp.collectedCoins;
        int totalcoin = _Cp.totalcoin;
        
        
        
        ScoreText.text = " Coins ";
        HighscoreText.text = (score-1).ToString()  + " / " + (totalcoin-1).ToString(); //I put -1 because I couldn't find how to start counting the pieces when the scene is launched. I'm sure there is a solution but I didn't find anything. I put a piece on the player as I did. its it launches the direct counting it's not the best option but hey that's what I found
    }
}
