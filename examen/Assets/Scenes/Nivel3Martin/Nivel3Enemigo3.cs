using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Nivel3Enemigo3 : MonoBehaviour
{
    public float AttackRange;
    
    private float TimeBetwenAttack;

    public GameObject Proyectile;
    
    private GameObject Objetctive;
    private Rigidbody2D Rb2D;
    // Start is called before the first frame update
    void Start()
    {
        Rb2D = GetComponent<Rigidbody2D>();
        Objetctive = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //Halla la distancia
        float distance = Vector2.Distance(transform.position, Objetctive.transform.position);

        //si la distancia es menor al rango de ataque, dispara
        if(distance < AttackRange)
        {
            if(TimeBetwenAttack <= 0)
            {
                Shoot();
            }
            else
            {
                TimeBetwenAttack -= Time.deltaTime;
            }
        }
    }

    private void Shoot()
    {
        Instantiate(Proyectile, transform.position, quaternion.identity);
    }
}
