using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputInteraction : MonoBehaviour
{
    [SerializeField] float RayDis;
    [SerializeField] float JumpPower;
    [SerializeField] LayerMask GroundLayer;

    private Rigidbody2D rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
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
