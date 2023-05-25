using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public GameObject bullet;
    public Transform firepoint;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void fire()
    { Instantiate(bullet, firepoint.position, firepoint.rotation); }//instantiate nos deja crear objetos a base de nuestro prefab

}
