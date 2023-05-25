using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class _VecesGanado : MonoBehaviour
{
    public TextMeshProUGUI GanarText;

    void Update()
    {
        GanarText.text = $"Victorias vistas:{_CounterWin.winCounter:0}";
    }
}
