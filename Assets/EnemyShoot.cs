using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject Bullet;

    public Transform firePoint;

    private float cadence = 3;

    private float timer = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void EShoot()
    {
        Instantiate(Bullet, firePoint.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = cadence;
            Instantiate(Bullet, transform);
            timer = 2;
            
        }
    }
}


