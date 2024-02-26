using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour{

    private float _currentSpeed;
    private bool _isRunning = false;

    [Header("Speed Setup")]
    public Rigidbody2D rb;
    public Vector2 friction = new Vector2(.1f, 0);
    public float speed, speedRun, forceJump = 2;

    [Header("Animation Setup")]
    public Animator animator;
    public float playerSwipeDuration = .1f;
    public string boolRun = "Run";

    // Update is called once per frame
    void Update(){
        HandleMoviment();
        HandleJump();
    }


    private void HandleMoviment(){

        //verificando se esta andando ou corrento
        if(Input.GetKey(KeyCode.LeftControl)){
            _currentSpeed = speedRun;
        }else{
            _currentSpeed = speed;
        }

        _isRunning = Input.GetKey(KeyCode.LeftControl);

        if(Input.GetKey(KeyCode.LeftArrow)){
            rb.velocity = new Vector2(-_currentSpeed, rb.velocity.y);
            AnimationMoviment(-1, true);
        }else if(Input.GetKey(KeyCode.RightArrow)){
            rb.velocity = new Vector2(_currentSpeed, rb.velocity.y);
             AnimationMoviment(1, true);
        }else{
             animator.SetBool(boolRun, false);
        }

        if(rb.velocity.x > 0){
            rb.velocity += friction;
        }else if(rb.velocity.x < 0){
            rb.velocity -= friction;
        }
    }

    private void AnimationMoviment(int x, bool SetRun){

        if(rb.transform.localScale.x != x){
            rb.transform.DOScaleX(x, playerSwipeDuration);
        }

        animator.SetBool(boolRun, SetRun);
    }


    public void HandleJump(){

        if(Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = Vector2.up * forceJump;
        }
    }
}