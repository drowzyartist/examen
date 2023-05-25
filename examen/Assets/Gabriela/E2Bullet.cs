using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2Bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private GameObject e2Bullet;

    public Vector2 direction;
    public float timer;
    public float maxTimer;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        Timer();
    }

    void Move()
    {
        rb.velocity = direction * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            //_CounterDead.deadCall += 1;
            //aqui cambio de escena
        }
    }

    void Timer() //cuanto dura en escena
    {
        timer += Time.deltaTime;

        if (timer >= maxTimer)
        {
            Destroy(gameObject);
        }
    }
}
