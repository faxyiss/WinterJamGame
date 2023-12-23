using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] SpriteRenderer spriteRenderer;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if(rb.velocity.x > 0.1f)
        {
            spriteRenderer.flipX = true;
            animator.SetBool("isWalk", true);
        }
        else if(rb.velocity.x == 0)
        {
            animator.SetBool("isWalk", false);
        }
        else if(rb.velocity.x < -0.1f)
        {
            spriteRenderer.flipX = false;
            animator.SetBool("isWalk", true);
        }
        else
        {
            animator.SetBool("isWalk", false);
        }
    }
}
