using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SOUIIntUpdateBigCoins : MonoBehaviour{

    public SOInt bigCoins;
    public TextMeshProUGUI uiTextValueBigCoins;

    // Start is called before the first frame update
    void Start(){
        uiTextValueBigCoins.text = bigCoins.value.ToString();
    }

    // Update is called once per frame
    void Update(){
        uiTextValueBigCoins.text = bigCoins.value.ToString();
    }
    
}