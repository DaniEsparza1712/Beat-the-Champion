using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : State
{
    private PlayerMachine sm;
    public MoveState(PlayerMachine pm) : base(pm){
        sm = pm;
    }
    public override void EnterState()
    {
    }
    public override void UpdateLogic()
    {
        if(Mathf.Abs(Input.GetAxis("Horizontal")) == 0 && !sm.pauseManager.paused){
            sm.animator.SetTrigger("Idle");
            sm.ChangeState(sm.idle);
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
        Vector3 moveVector;
        moveVector = Input.GetAxisRaw("Horizontal") * Vector3.right * sm.speed;
        sm.controller.Move(moveVector * Time.deltaTime);
    }

}
