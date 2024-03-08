using System.Collections;
using System.Collections.Generic;
using Core.Singleton;
using UnityEngine;
using TMPro;

public class UIInGameManager : Singleton<UIInGameManager>{

    public TextMeshProUGUI uiTxtCoins;

    public void UpdateTextCoins(string s){
        Instance.uiTxtCoins.text = s;// instance para pegar valor text no método static
    }
}