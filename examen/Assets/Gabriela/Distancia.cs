using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Distancia : MonoBehaviour
{
    public GameObject texto;
    public TMPro.TextMeshProUGUI distanciaText;
    public float distancia;
    public float distanciaInicial;
    public Transform player;

    private void Awake()
    {
        texto = GameObject.Find("Distancia");
        distanciaText = texto.GetComponent<TMPro.TextMeshProUGUI>();
        player = GameObject.FindWithTag("Player").GetComponent<Transform>(); 
    }

    void Start()
    {
        distanciaInicial = Vector2.Distance(player.position, transform.position);
    }

    
    void Update()
    {
        distancia = Vector2.Distance(player.position, transform.position);
        Distance();
    }

    void Distance()
    {
        distanciaText.text = "Distancia: " + (distanciaInicial - distancia);
    }
}
