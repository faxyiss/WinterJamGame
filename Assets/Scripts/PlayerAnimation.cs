using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class PlayerAnimation : MonoBehaviour
{

    // animator.SetBool("isWalk", true);
    //animator.SetBool("isFall", false);
    //animator.SetBool("isJump", false);


    [SerializeField] Animator animator;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] PlayerMovementController pmc;
    
    public static  bool isFlip = true;

    private enum MovementState { idle, running, jumping, falling, death }
    MovementState state;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        Flip();
        UpdateAnimationState();
        
    }
    private void UpdateAnimationState()
    {       
        if ((rb.velocity.x < -.1f || rb.velocity.x > .1f) & pmc.GroundCheck() )
        {
            state = MovementState.running;           
        }       
        else if(pmc.GroundCheck())
        {
            state = MovementState.idle;
        }
        else
        {
            if (rb.velocity.y > .1f)
            {
                state = MovementState.jumping;
            }
            else if (rb.velocity.y < -.1f)
            {
                state = MovementState.falling;
            }
            else
            {
                state = MovementState.falling;
            }
        }       
        animator.SetInteger("State", (int)state);
    }
    private void Flip()
    {
        if (rb.velocity.x > 0.1f)
        {
            spriteRenderer.flipX = true;
            isFlip = true;
        }
        else if(rb.velocity.x < -0.1f)
        {
            spriteRenderer.flipX = false;
            isFlip = false;
        }
    }

    public void DeathAnim()
    {
        
        animator.SetTrigger("Death");
    }
}
