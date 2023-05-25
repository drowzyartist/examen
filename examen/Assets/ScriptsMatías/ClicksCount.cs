using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicksCount : MonoBehaviour
{
    public int count;

    private void Awake()
    {
        
    }
    public void ClickButton()
    {
        count++;
    }
    
}
