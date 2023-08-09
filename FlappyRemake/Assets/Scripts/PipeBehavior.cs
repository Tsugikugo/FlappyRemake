using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeBehavior : MonoBehaviour
{
    private float speed = 1.5f;
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
