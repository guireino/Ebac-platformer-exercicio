using System;
using System.Collections;
using System.Collections.Generic;
using Core.Singleton;
using UnityEngine;
using TMPro;

public class ItemManager : Singleton<ItemManager>{

    public SOInt coins;
    public TextMeshProUGUI uiTextCoins;

    private void Start(){
        Reset();
    }

    private void Reset(){
        coins.value = 0;
        UpdateUI();
    }

    public void AddCoins(int amount = 1){
        coins.value += amount;
        UpdateUI();
    }

    private void UpdateUI(){ // usamos SOUIIntUpdate para atualizar UI coins
       //UIInGameManager.Instance.UpdateTextCoins(coins.value.ToString());
    }
   
}