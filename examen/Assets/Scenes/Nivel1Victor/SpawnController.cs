using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject enemy;
    private float timer;
    public float maxTimer;
    private Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>= maxTimer)
        {
            ChooseSpawnPoint();
            SpawnEnemy();
            timer = 0;
        }
    }

    void ChooseSpawnPoint()
    {
        float number = Random.Range(1, 8);
        switch(number)
        {
            case 1:
                spawnPoint = transform.GetChild(0);
                break;

            case 2:
                spawnPoint = transform.GetChild(1);
                
                break;

            case 3:
                spawnPoint = transform.GetChild(2);
                break;

            case 4:
                spawnPoint = transform.GetChild(3);
                break;

            case 5:
                spawnPoint = transform.GetChild(4);
                break;

            case 6:
                spawnPoint = transform.GetChild(5);
                break;

            case 7:
                spawnPoint = transform.GetChild(6);
                break;
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemy, spawnPoint.position, Quaternion.identity);
    }

}