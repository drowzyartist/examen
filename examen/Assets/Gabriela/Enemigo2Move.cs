using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemigo2Move : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public Vector2 direction;
    public float timer;
    public float maxTimer;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        maxTimer = 1;
        speed = 2;
    }


    void Update()
    {
        Move();
        ChangeDirection();
    }

    private void Move()
    {
        rb.velocity= -direction * speed;
    }

    void ChangeDirection()
    {
        timer += Time.deltaTime;

        if (timer >= maxTimer)
        {
            direction *= -1;
            timer = 0;
        }
    }
}
