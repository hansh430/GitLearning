using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMover : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * movement * speed;
    }
}
