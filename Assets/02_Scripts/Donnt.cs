using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donnt : MonoBehaviour
{
    [SerializeField] float X = 1.8f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Camera.main.orthographicSize -= 1;
            transform.position = new Vector2(transform.position.x + X, transform.position.y);

            if(Camera.main.orthographicSize == 5)
            {
                X = 0;
            }
            else if(Camera.main.orthographicSize > 5)
            {
                X = 1.8f;
            }
        }
    }
}
