using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_N1Controller : MonoBehaviour
{
    float speed;
    private Rigidbody2D enemy_rb;
    private Transform player;
    // Start is called before the first frame update
    private void Awake()
    {
        enemy_rb = gameObject.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void Move()
    {
        Vector2 direccion = player.position - transform.position;
        transform.up = direccion.normalized;
        enemy_rb.AddForce(new Vector2(direccion.x, direccion.y) * speed, ForceMode2D.Impulse);
    }

    private void OnEnable()
    {
        Move();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bullet"))
        {

        }
    }
}
