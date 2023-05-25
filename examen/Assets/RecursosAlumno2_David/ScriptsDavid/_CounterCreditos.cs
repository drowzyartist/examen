using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _CounterCreditos : MonoBehaviour
{
    public static int deadCounter { get; private set; }

    void Start()
    {
        deadCounter +=1;  
    }
}
