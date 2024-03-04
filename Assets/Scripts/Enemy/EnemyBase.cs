using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour{

    public HealthBase healthBase;
    public Animator animator;
    public string triggerAttack = "Attack", triggerKill = "Kill";
    public int damage;
    public float timeToDestroy = 1f;


    private void Start(){

        if(healthBase != null){
            healthBase.OnKill += OnEnemyKill; // add += registando morte inimigo
        }
    }

    private void OnCollisionEnter2D(Collision2D col) {
        
        var health = col.gameObject.GetComponent<HealthBase>(); // buscando scripts HealthBase

        if(health != null){
            health.Damage(damage);
        }
    }
    
    private void OnEnemyKill(){
        healthBase.OnKill -= OnEnemyKill;
        PlayDeathAnimation();
        Destroy(gameObject, timeToDestroy);
    }

     private void PlayDeathAnimation(){
        animator.SetTrigger(triggerKill);
    }

    public void Damage(int amount){
        healthBase.Damage(amount);
    }
}