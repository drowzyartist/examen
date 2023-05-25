using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class _VecesCredito : MonoBehaviour
{
    public TextMeshProUGUI CreditoText;

    void Update()
    {
        CreditoText.text = $"Creditos vistos:{_CounterCreditos.deadCounter:0}";
    }
}
