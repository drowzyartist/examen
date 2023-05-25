using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    GameObject target;
    public float speed;

    ScoreManager5 scoreManager5;

    private Rigidbody2D Rb2D;

    private void Start()
    {
        scoreManager5 = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager5>();
        Rb2D = GetComponent<Rigidbody2D>();

        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 Dir = (target.transform.position - transform.position).normalized * speed;
        Rb2D.velocity = new Vector2(Dir.x,Dir.y);
        
        Destroy(this.gameObject, 2);
        scoreManager5.DecreseScore();
    }

}
