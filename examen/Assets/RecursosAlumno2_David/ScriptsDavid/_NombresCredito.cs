using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class _NombresCredito : MonoBehaviour
{
    [Header("Time Variables")]
    [SerializeField] private float timer;
    [SerializeField] private float maxTimer;

    [Header("TextUI Variables")]
    [SerializeField] public TextMeshProUGUI nameText;

    void Update()
    {
        timer += Time.deltaTime;

        addName();

    }
    private void addName()
    {
        if(timer >= 10)
        {
        nameText.text = "-David Cardenas";
        }
        if (timer >= 20)
        {
            nameText.text = "-Victor Sanchez";
        }
        if (timer >= 30)
        {
            nameText.text = "-Gabriela Victoria";
        }
        if (timer >= 40)
        {
            nameText.text = "-Francesca Olcese";
        }
        if (timer >= 50)
        {
            nameText.text = "-Matias Quintanilla";
        }
        if (timer >= maxTimer)
        {
            nameText.text = "-Martin Akimoto";
            timer = 0;
        }
    }
}

