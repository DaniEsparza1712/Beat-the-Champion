using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathState : State
{
    PlayerMachine sm;
    public DeathState(PlayerMachine pm): base(pm){
        sm = pm;
    }
    public override void EnterState()
    {
        sm.controller.enabled = false;
    }

    public override void UpdateLogic()
    {
        
    }
    public override void UpdatePhysics()
    {
    }
}
