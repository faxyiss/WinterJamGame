using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PlayerMovementController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _acceleration;
    [SerializeField] private float _decceleration;
    [SerializeField] private float _velPower;
    private float _moveDirection;

    [Header("Jump")]
    [SerializeField] private float _jumpForce;

    [Header("Ground Check")]
    [SerializeField] private LayerMask _groundLayer;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private float _groundCheckSize;



    private RaycastHit2D _groundCheckRay;

    bool _onAir = false;
    

    void Start()
    {
     _rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        GroundCheck();
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
        
        return Physics2D.OverlapCircle(_groundCheck.position,_groundCheckSize , _groundLayer);
    }
    
    private void Move()
    {
        float _targetSpeed = _movementSpeed * _moveDirection;
        float _speedDif = _targetSpeed - _rb.velocity.x;
        float _accelRate = (Mathf.Abs(_targetSpeed) > 0.01f) ? _acceleration : _decceleration;
        float _movement = MathF.Pow(MathF.Abs(_speedDif) * _accelRate, _velPower) * Mathf.Sign(_speedDif);
        _rb.AddForce(_movement * Vector2.right);
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
