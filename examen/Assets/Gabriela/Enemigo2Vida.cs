using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2Vida : MonoBehaviour
{
    public GameObject Enemy;
    public int HP = 2;

    void Life(int value)
    {
        HP += value;

        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Life(-1);
        }
    }
}
