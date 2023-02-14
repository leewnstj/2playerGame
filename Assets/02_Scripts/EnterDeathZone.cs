using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterDeathZone : MonoBehaviour
{
    [SerializeField] PlayerDeath opd;
    [SerializeField] PlayerDeath tpd;

    [SerializeField] GameObject Ccamera;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("1Player"))
        {
            opd.playerDead = true;
            StopCamera();
        }
        if (collision.CompareTag("2Player"))
        {
            tpd.playerDead = true;
            StopCamera();
        }
    }

    private void StopCamera()
    {
        Ccamera.SetActive(false);
    }
}
