using System;
using System.Collections;
using System.Collections.Generic;
using Core.Singleton;
using UnityEngine;
using TMPro;

public class ItemManager : Singleton<ItemManager>{

    public int coins;
    public TextMeshProUGUI uiTextCoins;

    private void Start(){
        Reset();
    }

    private void Reset(){
        coins = 0;
        UpdateUI();
    }

    public void AddCoins(int amount = 1){
        coins += amount;
        Debug.Log("coins " + coins);
        UpdateUI();
    }

    private void UpdateUI(){
       UIInGameManager.Instance.UpdateTextCoins(coins.ToString());
    }
   
}