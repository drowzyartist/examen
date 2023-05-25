using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControler : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnEnable()
    {
        Destroy(gameObject, 3.5f);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
