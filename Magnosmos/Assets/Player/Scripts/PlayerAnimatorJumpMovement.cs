using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorJumpMovement : PlayerAnimatorBase
{
    [SerializeField]
    private float m_jumpSpeed = 1f;

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(Input.GetKeyDown(KeyCode.Space))
            data.playerMovement.AddVerticalMovement(m_jumpSpeed);
    }
}
