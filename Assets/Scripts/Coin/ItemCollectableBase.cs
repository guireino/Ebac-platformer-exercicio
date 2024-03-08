using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectableBase : MonoBehaviour{

    public string compareTag = "Player";

    private void OnTriggerEnter2D(Collider2D col) {
        
        if(col.transform.CompareTag(compareTag)){
            Collect();
        }
    }

    protected virtual void Collect(){
        Debug.Log("collect");
        gameObject.SetActive(false);
        OnCollect();
    }

    // public void AddCoins(int amount = 1){
    //     coins += amount;
    //     OnCollect();
    // }

    protected virtual void OnCollect(){

    }

}