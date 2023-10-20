using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMachine : StateMachine
{
    [HideInInspector] public IdleState idle;
    [HideInInspector] public MoveState move;
    [HideInInspector] public AttackState attack;
    [HideInInspector] public DeathState death;
    public Animator animator;
    public Collider attackCollider;
    public PauseManager pauseManager;
    public float speed;
    public bool gameLost = false;
    private void Awake() {
        idle = new IdleState(this);
        move = new MoveState(this);
        attack = new AttackState(this);
        death = new DeathState(this);

        currentState = idle;
        currentState.EnterState();

        attackCollider.enabled = false;
    }
    public void ChangeAttackCollider(string attackCase){
        switch(attackCase){
            case "activate":
                attackCollider.enabled = true;
                break;
            case "deactivate":
                attackCollider.enabled = false;
                break;
        }
    }
    public void GameLost(){
        gameLost = true;
    }
}
