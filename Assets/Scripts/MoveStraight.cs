using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraight : MonoBehaviour
{
    private float speed = 100.0f;

    void Update()
    {
        Move();
    }

    void Move()
    {
        // Simply continuously moving by transform.translate
        transform.Translate(Vector3.up * Time.deltaTime * speed);   
    }
}
