using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMachine : StateMachine
{
    [HideInInspector] public MoveEnemy move;
    [HideInInspector] public int speed;
    public int baseSpeed;
    public int speedRandomModifier;
    public AudioSource audioSource;
    public AudioClip audioClip;
    private void Awake() {
        move = new MoveEnemy(this);
        currentState = move;

        currentState.EnterState();
    }
    private void OnEnable() {
        audioSource.PlayOneShot(audioClip);
        speed = Random.Range(baseSpeed-speedRandomModifier, baseSpeed+speedRandomModifier);
    }
}
