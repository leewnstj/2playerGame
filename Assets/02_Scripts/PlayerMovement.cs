using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float PlayerSpeed;
    [SerializeField] float RayDis;
    [SerializeField] float JumpPower;
    [SerializeField] LayerMask GroundLayer;
    public float X;

    private Rigidbody2D rigid;
    private Animator anim;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
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
            1 => new Vector2(1,1),
            -1 => new Vector2(-1, 1),
            _ => transform.localScale
        };
    }

    public void PlayerJump(KeyCode UpMove)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, RayDis, GroundLayer);

        if (hit && Input.GetKeyDown(UpMove))
        {
            rigid.velocity = new Vector2(rigid.velocity.x, JumpPower);
        }
    }
}
