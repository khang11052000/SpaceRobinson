using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement1 : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    private Vector2 movement;

    //private Rigidbody2D _rb;
    private Vector2 _mousePos;
    
    private bool _facingRight = true;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        _mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Move();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    
    private void Move()
    {
        

        if (_mousePos.x > transform.position.x && !_facingRight)
        {
            Flip();
        } else if (_mousePos.x < transform.position.x && _facingRight)
        {
            Flip();
        }
    }

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        _facingRight = !_facingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
