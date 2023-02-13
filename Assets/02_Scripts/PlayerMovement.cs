using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float PlayerSpeed;
    public float X;

    private Rigidbody2D rigid;
    private Animator anim;

    private float inputX;
    private float inputY;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        inputX = transform.localScale.x;
        inputY = transform.localScale.y;
    }

    public void Movement(KeyCode LeftMove,KeyCode RightMove)
    {
        if (Input.GetKeyDown(LeftMove))
        {
            X = -1;
        }
        if (Input.GetKeyDown(RightMove))
        {
            X = 1;
        }
        if (Input.GetKeyUp(RightMove) || Input.GetKeyUp(LeftMove))
        {
            X = 0;
        }
        
        rigid.velocity = new Vector2(X * PlayerSpeed, rigid.velocity.y);
        anim.SetFloat("X", X);

        FlipPlayer();
    }

    private void FlipPlayer()
    {
        transform.localScale = X switch
        {
            1 => new Vector2(inputX, inputY),
            -1 => new Vector2(-inputX, inputY),
            _ => transform.localScale
        };
    }
}
