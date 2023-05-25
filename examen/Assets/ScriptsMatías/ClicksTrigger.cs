using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicksTrigger : MonoBehaviour
{
    public CliksTMP cliks;
    public ClicksCount clicksCount;
    public void Update()
    {
        cliks.ChangeClicks(clicksCount.count);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ClickNivel1"))
        {
            cliks = GameObject.FindWithTag("ClickNivel1").GetComponent<CliksTMP>();
            clicksCount = GameObject.FindWithTag("ClickNivel1").GetComponent<ClicksCount>();
            cliks.ChangeClicks(clicksCount.count);
        }
        if (collision.gameObject.CompareTag("ClickNivel2"))
        {
            cliks = GameObject.FindWithTag("ClickNivel2").GetComponent<CliksTMP>();
            clicksCount = GameObject.FindWithTag("ClickNivel2").GetComponent<ClicksCount>();
            cliks.ChangeClicks(clicksCount.count);
        }
        if (collision.gameObject.CompareTag("ClickNivel3"))
        {
            cliks = GameObject.FindWithTag("ClickNivel3").GetComponent<CliksTMP>();
            clicksCount = GameObject.FindWithTag("ClickNivel3").GetComponent<ClicksCount>();
            cliks.ChangeClicks(clicksCount.count);
        }
        if (collision.gameObject.CompareTag("ClickCreditos"))
        {
            cliks = GameObject.FindWithTag("ClickCreditos").GetComponent<CliksTMP>();
            clicksCount = GameObject.FindWithTag("ClickCreditos").GetComponent<ClicksCount>();
            cliks.ChangeClicks(clicksCount.count);
        }
    }
}
