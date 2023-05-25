using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebotador : MonoBehaviour
{
    public float speed;
    public Rigidbody2D _rb;
    public Vector2 direction;
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Move();
    }

    void Move()
    {
        _rb.velocity = direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ReboteX"))
        {
            direction.x *= -1;
        }
        if (collision.gameObject.CompareTag("ReboteY"))
        {
            direction.y *= -1;
        }
        
    }
}
