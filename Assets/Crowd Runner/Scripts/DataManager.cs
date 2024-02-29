using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{

    public static DataManager instance;

    [Header(" Coin Texts ")]
    [SerializeField] private Text[] coinsTexts;
    private int coins;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        coins = PlayerPrefs.GetInt("coins", 0);
    }

    private void Start()
    {
        UpdateCoinsTexts();
    }

    private void UpdateCoinsTexts()
    {
        foreach(Text coinText in coinsTexts)
        {
            coinText.text = coins.ToString();
        }
    }

    public void AddCoins(int amount)
    {
        coins += amount;
        PlayerPrefs.SetInt("coins", coins);
        UpdateCoinsTexts();
    }
    
}
