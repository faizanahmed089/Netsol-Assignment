using System;
using UnityEngine;

public class AircraftController : MonoBehaviour
{ 
    private float speed = 40.0f;
    private float forwardBackwardSpeed = 200.0f;
    private float rotationSpeed;
    private float verticalInput;
    private float horizontalInput;
    private Vector3 rotateChange;

    public GameObject bulletPrefab;

    //[SerializeField] GameObject bullet;

    //float fireRate;
    //float nextFire;

    void Start()
    {
        //fireRate = 1f;
        //nextFire = Time.time;
    }

    void Update()
    {
        //CheckIfTimeToFire();
        RotateLeftRight();
        MoveUpDown();
        InstantiateBullet();
     
        // Gets users vertical and horizontal input from arrow keys or WASD
        verticalInput = Input.GetAxis("Vertical");  
        horizontalInput = Input.GetAxis("Horizontal");   
    }

    void FixedUpdate()
    {
        MoveFowardBackward();
    }

    //void CheckIfTimeToFire()
    //{
    //    if (Time.time > nextFire)
    //    {
    //        //Instantiate(bullet, transform.position, Quaternion.identity);
    //        Instantiate(bullet, new Vector3(0, 500, -455), Quaternion.Euler (90, 0, 0));
    //        nextFire = Time.time + fireRate;
    //    }
    //}

    void InstantiateBullet()
    {
        // When pressing space key, bullet will active. IT removes the need to instantiate a new object and efficiently requests and acquires*
        // *a game object that is only pre instantiated, relieving the burden from CPU to create and destroy a new one
        if (Input.GetKeyDown(KeyCode.Space))    
        {
            GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();
            if (bullet != null)
            { 
                bullet.transform.position = transform.position;
                bullet.SetActive(true);
            }
        }
    }

    void MoveFowardBackward()
    {
        // Move plane forward/backward by pressing Q/Z key
        if (Input.GetKey(KeyCode.Q)) 
        {
            transform.Translate(Vector3.forward * Time.deltaTime * forwardBackwardSpeed);  
        }
        
        if (Input.GetKey(KeyCode.Z)) 
        {
            transform.Translate(Vector3.back * Time.deltaTime * forwardBackwardSpeed);   
        }
    }

    void RotateLeftRight()
    {
        // Rotate plane right/left based on horizontal input keys
        transform.Rotate(Vector3.up * Time.deltaTime * speed * horizontalInput);    
    }

    void MoveUpDown()
    {
        // Rotate plane up/down based on vertical input keys
        transform.Translate(Vector3.up * Time.deltaTime * speed * verticalInput);   
    }
}