using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum obstacle
{
    DownObs
}
public class Obstacle : MonoBehaviour
{
    [SerializeField] obstacle obs;
    [SerializeField] GameObject mine;
    [SerializeField] float waitTime;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("1Player") || collision.collider.CompareTag("2Player"))
        {
            if(obs == obstacle.DownObs)
            {
                StartCoroutine(DownObs());
            }
        }
    }

    IEnumerator DownObs()
    {
        yield return new WaitForSeconds(waitTime);
        mine.SetActive(false);
    }
}
