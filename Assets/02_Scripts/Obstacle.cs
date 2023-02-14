using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum obstacle
{
    DownObs
}
public class Obstacle : MonoBehaviour
{
    [SerializeField] float waitTime;
    [SerializeField] float speed;
    [SerializeField] obstacle obj;
    [SerializeField] Transform endMove;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("1Player")|| collision.collider.CompareTag("2Player"))
        {
            if(obj == obstacle.DownObs)
            {
                StartCoroutine(DownObstacle());
            }
        }
    }

    IEnumerator DownObstacle()
    {
        yield return new WaitForSeconds(waitTime);
    }
}
