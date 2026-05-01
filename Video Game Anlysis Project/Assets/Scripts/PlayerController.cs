using System;
using NUnit.Framework;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public float wallCheckRadius = 0.1f;
    public LayerMask groundLayer;
    public LayerMask wallLayer;
    public Transform wallCheckLeftTop;
    public Transform wallCheckLeftBot;
    public Transform wallCheckRightTop;
    public Transform wallCheckRightBot;

    private Rigidbody2D rb;
    private bool isGrounded;
    private bool isNextToWallLeft;
    private bool isNextToWallRight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");

        if (isGrounded)
        {
            rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
        }
        else
        {
            if (!isNextToWallLeft && moveInput < 0)
            {
                rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
            }

            if (!isNextToWallRight && moveInput > 0)
            {
                rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        isNextToWallLeft = Physics2D.OverlapArea(wallCheckLeftBot.position, wallCheckLeftTop.position, groundLayer);
        isNextToWallRight = Physics2D.OverlapArea(wallCheckRightBot.position, wallCheckRightTop.position, groundLayer);
    }

}
