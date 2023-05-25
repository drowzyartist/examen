using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _CounterDead : MonoBehaviour
{
    public int deadCounter;
    public int deadCall;
    void Update()
    {
        if (deadCall > 0)
        {
            deadCounter = deadCall;
        }
    }
}
