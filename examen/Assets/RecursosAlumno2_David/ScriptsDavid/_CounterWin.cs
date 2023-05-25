using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _CounterWin : MonoBehaviour
{
    public static int winCounter { get; private set; }

    void Start()
    {
        winCounter += 1;
    }
}
