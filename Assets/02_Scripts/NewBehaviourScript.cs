using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Transform target1;
    [SerializeField] Transform target2;

    [SerializeField] Camera cam;
    [SerializeField] float smoothing;

    public float x;

    private void Start()
    {
        x = Camera.main.orthographicSize;
    }

    private void Update()
    {
        Vector3 camPos = new Vector3((target1.position.x + target2.position.x) / 2, (target1.position.y + target2.position.y) / 2 + 3, -10);
        cam.transform.position = Vector3.Lerp(cam.transform.position, camPos, smoothing);
    }
}
