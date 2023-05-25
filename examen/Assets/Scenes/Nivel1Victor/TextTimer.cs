using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTimer : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;
    public float timerText;
    public Player_SceneManager player;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerText = player.timer;
        ChangeText();
    }

    void ChangeText()
    {
        text.text = "Tiempo: " + (player.maxTimer - timerText);
    }
}
