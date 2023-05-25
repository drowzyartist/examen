using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _CounterDead : MonoBehaviour
{
    public static int deadsCounter { get; private set; }

    void Start()
    {
        deadsCounter += 1;
    }
}
