using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBase : MonoBehaviour{
    private int _currentLife;
    private bool _isDead;
    public Action OnKill;

    public int startLife = 10;
    public float delayTokill = 0f;
    public bool destroyOnkill = false;

    // Start is called before the first frame update
    void Start(){
        Init();
    }


    public void Init(){
        _isDead = false;
        _currentLife = startLife;
    }

    public void Damage(int damage){

        if (_isDead) return; // retornando o if para nao processar o resto do código, e ele estiver morto

        _currentLife -= damage;

        if(_currentLife <= 0){
            Kill();
        }
    }

    public void Kill(){

        _isDead = true;

        if(destroyOnkill){
            Destroy(gameObject, delayTokill);
        }

         OnKill?.Invoke(); // if(OnKill != null) = ?
    }
}
