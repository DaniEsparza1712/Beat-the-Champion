using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : State
{
    PlayerMachine sm;
    public AttackState(PlayerMachine pm): base(pm){
        sm = pm;
    }
    public override void EnterState()
    {
        sm.ChangeAttackCollider("activate");
        sm.controller.Move(Vector3.zero);
    }
    public override void UpdateLogic()
    {
        if(sm.GetChangeTo == "Idle"){
            sm.ChangeAttackCollider("deactivate");
            sm.SetChangeTo("");
            sm.animator.SetTrigger("Idle");
            sm.ChangeState(sm.idle);
        }
        else if(sm.GetChangeTo == "Death"){
            sm.ChangeAttackCollider("deactivate");
            sm.SetChangeTo("");
            sm.animator.SetTrigger("Death");
            sm.ChangeState(sm.death);
        }
    }
    public override void UpdatePhysics()
    {
        
    }
}
