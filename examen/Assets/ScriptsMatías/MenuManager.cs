using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public void Nivel1()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void Nivel2()
    {
        SceneManager.LoadScene("Nivel2");
    }
    public void Nivel3()
    {
        SceneManager.LoadScene("nivel 4");
    }
    public void Créditos()
    {
        SceneManager.LoadScene("Creditos");
    }
}
