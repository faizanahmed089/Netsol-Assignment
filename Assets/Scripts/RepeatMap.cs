using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatMap : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 0.008f;

    private Vector3 startPos;
    private float repeatWidth;

    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        RepetitionofMap();
        MoveBackward();
    }

    void RepetitionofMap()
    {
        if(transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }

    void MoveBackward()
    {
        rb.AddForce(Vector3.back * speed, ForceMode.Impulse);
    }
}
