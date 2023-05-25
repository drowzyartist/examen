using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_SceneManager : MonoBehaviour
{
    public float timer;
    public float maxTimer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= maxTimer)
        {
            SceneManager.LoadScene("Nivel2");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyN1"))
        {
            SceneManager.LoadScene("Derrota");
        }
    }

}

