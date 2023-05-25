using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager5 : MonoBehaviour
{
    private float Score = 10;
    private TextMeshProUGUI textmesh;
    // Start is called before the first frame update
    void Start()
    {
        textmesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textmesh.text = Score.ToString();
    }

    public void DecreseScore()
    {
        Score--;
    }
}
