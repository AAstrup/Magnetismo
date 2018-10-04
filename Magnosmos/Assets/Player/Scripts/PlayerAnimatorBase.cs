using UnityEngine;

public class PlayerAnimatorBase : StateMachineBehaviour
{
    protected Animator animator;
    protected PlayerAnimatorSharedData data;

    public void Initialize(Animator animator, PlayerAnimatorSharedData playerAnimatorSharedData)
    {
        this.animator = animator;
        this.data = playerAnimatorSharedData;
    }
}