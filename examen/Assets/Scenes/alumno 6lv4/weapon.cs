using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public float fireForce;
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
    { GameObject projectile = Instantiate(bullet, firepoint.position, firepoint.rotation);
        projectile.GetComponent<Rigidbody2D>().AddForce(firepoint.up * fireForce, ForceMode2D.Impulse);
    }//instantiate nos deja crear objetos a base de nuestro prefab


}
