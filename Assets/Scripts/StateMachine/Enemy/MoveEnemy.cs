using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : State
{
    public EnemyMachine sm;
    public MoveEnemy(EnemyMachine em): base(em){
        sm = em;
    }

    public override void EnterState()
    {
        
    }
    public override void UpdateLogic()
    {
        
    }
    public override void UpdatePhysics()
    {
        sm.transform.Translate(sm.transform.forward * sm.speed * Time.deltaTime);
    }
}
