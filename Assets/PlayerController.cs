using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveX;
    private float moveY;
    public float moveSpeed = 5.0f;
    static int playerHealth = 5;

    Transform playerTransform;
    public Transform firePoint;
    public bool canShoot = false;
    public GameObject Bullet;

    public float cadence = 3;
    private float counter;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed;
        moveY = Input.GetAxis("Vertical") * moveSpeed;
        rb.velocity = new Vector2(moveX, moveY);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

      
    }

    void Shoot()
    {
        Instantiate(Bullet, firePoint.transform.position, Quaternion.identity);
    }

}
