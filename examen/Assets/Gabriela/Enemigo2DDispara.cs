using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2DDispara : MonoBehaviour
{
    public GameObject e2Bullet;
    public float timer;
    public float maxTimer = 2;
    public Enemigo2Move E2Move;

    private void Awake()
    {
        E2Move = GetComponent<Enemigo2Move>();
    }

    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        timer = Time.deltaTime;

        if (timer > maxTimer)
        {
            GameObject obj = Instantiate(e2Bullet);
            obj.transform.position = transform.position;
            obj.GetComponent<E2Bullet>().direction = E2Move.direction;

            timer = 0;
        }
    }
}
