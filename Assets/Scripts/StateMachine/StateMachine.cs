using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{
    public CharacterController controller;
    public string changeTo;
    public string GetChangeTo => changeTo;
    [HideInInspector] public State currentState;

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateLogic();
    }
    private void LateUpdate() {
        currentState.UpdatePhysics();    
    }

    public void ChangeState(State newState){
        currentState = newState;
        newState.EnterState();
    }
    public void SetChangeTo(string change){
        changeTo = change;
    }
}
