using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desactivador : MonoBehaviour
{
    public float timer, maxTimer;
    public bool rebotando;

    private void Awake()
    {
        rebotando = false;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= maxTimer && rebotando == false)
        {
            timer = 0;
            rebotando = true;
        }
        if(rebotando == true)
        {

        }

        
    }
}
