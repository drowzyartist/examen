using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class _VecesMuerto : MonoBehaviour
{
    public TextMeshProUGUI DeadText;

    void Update()
    {
        DeadText.text = $"Derrotas vistas:{_CounterDead.deadsCounter:0}";
    }
}
