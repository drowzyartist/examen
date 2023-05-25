using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desactivador : MonoBehaviour
{
    public float timer, maxTimer;
    public bool rebotando;
    public GameObject FondoMenu;
    public GameObject Nivel1Button;
    public GameObject Nivel2Button;
    public GameObject Nivel3Button;
    public GameObject CreditosButton;
    public GameObject MenuTMP;
    public GameObject ClicksNivel1;
    public GameObject ClicksNivel2;
    public GameObject ClicksNivel3;
    public GameObject ClicksCreditos;
    public GameObject Rebotador;
    private void Awake()
    {
        rebotando = false;
        Rebotador.SetActive(false);
    }
    void Update()
    {
        if (rebotando == false) 
        { 
            timer += Time.deltaTime;
        }
        if(timer >= maxTimer && rebotando == false)
        {
            timer = 0;
            rebotando = true;
        }
        if (Input.GetMouseButtonDown(0))
        {
            timer = 0;
            FondoMenu.SetActive(true);
            Nivel1Button.SetActive(true);
            Nivel2Button.SetActive(true);
            Nivel3Button.SetActive(true);
            CreditosButton.SetActive(true);
            MenuTMP.SetActive(true);
            ClicksCreditos.SetActive(true);
            ClicksNivel1.SetActive(true);
            ClicksNivel2.SetActive(true);
            ClicksNivel3.SetActive(true);
            Rebotador.SetActive(false);
            rebotando = false;
        }
        if(rebotando == true)
        {
            Desactivar();
        }

    }
    void Desactivar()
    {
        Rebotador.SetActive(true);
        FondoMenu.SetActive(false);
        Nivel1Button.SetActive(false);
        Nivel2Button.SetActive(false);
        Nivel3Button.SetActive(false);
        CreditosButton.SetActive(false);
        MenuTMP.SetActive(false);
        ClicksCreditos.SetActive(false);
        ClicksNivel1.SetActive(false);
        ClicksNivel2.SetActive(false);
        ClicksNivel3.SetActive(false);
    }
}
