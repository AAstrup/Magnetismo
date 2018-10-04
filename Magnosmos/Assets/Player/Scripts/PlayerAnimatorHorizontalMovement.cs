using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorHorizontalMovement : PlayerAnimatorBase
{
    [SerializeField]
    private float m_moveSpeed = 1f;
    [SerializeField]
    private float m_brakePercentageSpeed = 100f;

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        var input = Input.GetAxisRaw("Horizontal");
        if (Mathf.Abs(input) > 0.1f)
        {
            //if (GetSign(input) != GetSign(data.playerMovement.body.velocity.x))
            //    data.playerMovement.BrakeHorizontalMovement(m_brakePercentageSpeed * Time.deltaTime);

            data.playerMovement.SetHorizontalMovement(input * Time.deltaTime * m_moveSpeed);
        }
        else
            data.playerMovement.BrakeHorizontalMovement(m_brakePercentageSpeed * Time.deltaTime);
    }

    private int GetSign(float input)
    {
        if (input < 0)
            return -1;
        else
            return 1;
    }
}
