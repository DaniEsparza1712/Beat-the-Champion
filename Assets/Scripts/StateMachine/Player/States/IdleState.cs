using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    public PlayerMachine sm;
    public IdleState(PlayerMachine pm): base(pm){
        sm = pm;
    }
    public override void EnterState(){
    }
    public override void UpdateLogic()
    {
        if(Mathf.Abs(Input.GetAxis("Horizontal")) > 0 && !sm.pauseManager.paused){
            sm.animator.SetTrigger("Walk");
            sm.ChangeState(sm.move);
        }
        else if(Input.GetButtonDown("Fire1") && !sm.pauseManager.paused){
            sm.animator.SetTrigger("Attack");
            sm.ChangeState(sm.attack);
        }
        else if(sm.GetChangeTo == "Death" && !sm.pauseManager.paused){
            sm.SetChangeTo("");
            sm.animator.SetTrigger("Death");
            sm.ChangeState(sm.death);
        }
    }
    public override void UpdatePhysics()
    {
        
    }
}
