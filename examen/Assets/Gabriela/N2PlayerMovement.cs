using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N2PlayerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector2 direction;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Move();
    }

    void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        if (vertical <= 0) //player solo puede avanzar
        {
            vertical = 0;
        }

        rb.velocity = new Vector2(horizontal, vertical) * speed;
    }
}