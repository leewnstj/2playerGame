using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dont : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Camera.main.orthographicSize += 1;
            transform.position = new Vector2(transform.position.x - 1.8f, transform.position.y);
        }
    }
}
