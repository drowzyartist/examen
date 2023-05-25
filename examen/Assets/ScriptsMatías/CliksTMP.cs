using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CliksTMP : MonoBehaviour
{
    public TMP_Text cliksText;
     void Awake()
    {
        cliksText = GetComponent<TMP_Text>();
    }

    public void ChangeClicks(int click)
    {
        cliksText.text = "Clicks: " + click;
    }
}
