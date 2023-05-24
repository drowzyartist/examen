using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementNivel3 : MonoBehaviour
{
    public float speed = 10;

    private Rigidbody2D Rb2D;
    void Start()
    {
        Rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float MoveX;
        float MoveY;
        MoveX = Input.GetAxisRaw("Horizontal");
        MoveY = Input.GetAxisRaw("Vertical");

        Rb2D.velocity = new Vector2(MoveX*speed, MoveY*speed).normalized;
    }
}
