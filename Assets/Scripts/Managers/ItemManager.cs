using System;
using System.Collections;
using System.Collections.Generic;
using Core.Singleton;
using UnityEngine;
using TMPro;

public class ItemManager : Singleton<ItemManager>{

    public SOInt coins;
    public SOInt bigCoins;
    public TextMeshProUGUI uiTextCoins, uiTextBigCoins;

    private void Start(){
        Reset();
    }

    private void Reset(){
        coins.value = 0;
        bigCoins.value = 0;
        UpdateUI();
    }

    public void AddCoins(int amount = 1){
        coins.value += amount;
        UpdateUI();
    }

     public void AddBigCoins(int amount = 1){
        bigCoins.value += amount;
        UpdateUI();
    }


    private void UpdateUI(){ // usamos SOUIIntUpdate para atualizar UI coins
       //UIInGameManager.Instance.UpdateTextCoins(coins.value.ToString());
    }
   
}