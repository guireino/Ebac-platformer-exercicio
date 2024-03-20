using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectableBase : MonoBehaviour{

    public ParticleSystem particleSystem;
    public string compareTag = "Player";
    public GameObject graphicItem;
    public float timeToHide = 3;

    private void OnTriggerEnter2D(Collider2D col) {
        
        if(col.transform.CompareTag(compareTag)){
            Collect();
        }
    }

    protected virtual void Collect(){
        Debug.Log("collect");
        if(graphicItem != null) graphicItem.SetActive(false);
        Invoke("HideObject", timeToHide); // invoke chama um método por um tempo, para esperar efeitos das partículas antes do objeto ser destrói-o
        OnCollect();
    }

    // public void AddCoins(int amount = 1){
    //     coins += amount;
    //     OnCollect();
    // }

    private void HideObject(){
        gameObject.SetActive(false);
    }

    protected virtual void OnCollect(){
        if(particleSystem != null){
            particleSystem.Play();
        }
    }

}