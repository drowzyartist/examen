using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Nivel3Enemigo3 : MonoBehaviour
{
    public float AttackRange;

    private float Attack = 1;
    public float NextAttack;

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
        if (distance <= AttackRange && NextAttack < Time.time)
        {
            Instantiate(Proyectile);
            NextAttack = Time.time + Attack;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position,AttackRange);
    }
}
