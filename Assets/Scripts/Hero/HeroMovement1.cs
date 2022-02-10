using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement1 : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    private Vector2 movement;

    public Animator animator;

    private int cout = 0;
    

    //private Rigidbody2D _rb;
    private Vector2 _mousePos;
    
    private bool _facingRight = true;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        _mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        MoveFlip();

        if (Input.GetKeyDown(KeyCode.O))
        {
            cout = 0;
        }
        if (Input.GetButtonDown("buttonKhang"))
        {
            animator.SetBool("move", true);
            cout++;
        } else if (Input.GetButtonUp("buttonKhang"))
        {
            cout--;
            if (cout == 0)
            {
                animator.SetBool("move", false);
            }
        }
        //Debug.Log(cout);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    
    private void MoveFlip()
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
        
        _facingRight = !_facingRight;
        
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
