using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float speed = 15f;
    public Transform ball;
    private Vector2 origin, target;
    private float reach = -2.6f;


    void Update()
    {
        if (ball.position.y > transform.position.y && ball.position.x < reach)
        {
            transform.Translate(0f, speed * Time.deltaTime, 0f);
        }

        if (ball.position.y < transform.position.y && ball.position.x < reach)
        {
            transform.Translate(0f, -speed * Time.deltaTime, 0f);
        }

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4f, 4f), transform.position.z);

    }
}
