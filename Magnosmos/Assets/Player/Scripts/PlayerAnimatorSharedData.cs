using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator), typeof(PlayerMovement))]
public class PlayerAnimatorSharedData : MonoBehaviour {
    
    // Settings
    public float playerHeight = 1f;

    // References
    [HideInInspector]
    public Animator animator;
    [HideInInspector]
    public PlayerMovement playerMovement;

    // Animator keys
    public readonly string ON_GROUND = "OnGround";

    void Awake () {
        animator = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
        var animatorStates = GetComponent<Animator>().GetBehaviours<PlayerAnimatorBase>();
        foreach (var item in animatorStates)
        {
            item.Initialize(animator, this);
        }
    }
}
