using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputInteraction : MonoBehaviour
{
    [SerializeField] float RayDis;
    [SerializeField] float JumpPower;
    [SerializeField] LayerMask GroundLayer;
    [SerializeField] LayerMask player;

    private Rigidbody2D rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    public void PlayerJump(KeyCode UpMove)
    {
        RaycastHit2D hitJump = Physics2D.Raycast(transform.position, Vector2.down, RayDis + 0.4f, GroundLayer);
        RaycastHit2D cantJump = Physics2D.Raycast(transform.position, Vector2.up, RayDis, player);

        if (hitJump && Input.GetKeyDown(UpMove) && cantJump==false)
        {
            rigid.velocity = new Vector2(rigid.velocity.x, JumpPower);
        }
    }
}
