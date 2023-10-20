using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    public State(StateMachine sm){

    } 
    public abstract void EnterState();
    public abstract void UpdateLogic();
    public abstract void UpdatePhysics();
}
