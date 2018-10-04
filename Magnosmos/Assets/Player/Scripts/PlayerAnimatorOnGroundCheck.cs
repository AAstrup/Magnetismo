using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorOnGroundCheck : PlayerAnimatorBase {

    public LayerMask groundLayerMask;
    private float distanceFix = 1.1f;

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        bool isOnGround = false;
        isOnGround = Physics2D.Raycast(data.transform.position, -data.transform.up, (data.playerHeight / 2f) * distanceFix, groundLayerMask);
        animator.SetBool(data.ON_GROUND, isOnGround); 
    }
}
