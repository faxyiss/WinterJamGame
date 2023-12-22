using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PlayerMovementController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _movementSpeed;
    private float _moveDirection;

    [Header("Jump")]
    [SerializeField] private float _jumpForce;

    [Header("Ground Check")]
    [SerializeField] private LayerMask _groundLayer;


    private RaycastHit2D _groundCheckRay;

    bool _onAir = false;
    

    void Start()
    {
     _rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {        
        InputMoveDir();
        

        if (Input.GetKeyDown(KeyCode.Space) & GroundCheck())
        {
            Jump();
        }

    }
    private void FixedUpdate()
    {
        Move();
    }

    private bool GroundCheck()
    {
        return Physics2D.Raycast(transform.position, Vector2.down, 0.7f, _groundLayer);                   
    }
    private void Move()
    {

        _rb.velocity = new Vector2(_moveDirection * _movementSpeed * Time.fixedDeltaTime, _rb.velocity.y);
    }
    private void InputMoveDir()
    {
        _moveDirection = Input.GetAxisRaw("Horizontal");
    }
    private void Jump()
    {
        _rb.velocity = new Vector2(_moveDirection * _movementSpeed * Time.fixedDeltaTime, 0);
        _rb.AddForce(new Vector2(_rb.velocity.x, _jumpForce), ForceMode2D.Impulse);        
    }
}
