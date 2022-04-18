using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool isDestroyed = false;

    public static Enemy Instance { get; set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    // Call on collision enter method of enemy, check when its collide with bullet and enemy health > 33.34 else destroy enemy
    // Game object deactivate to return it to the pool
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            if (GameManager.Instance.enemyHealth.value > 33.34)
            {
                GameManager.Instance.BulletCollideWithEnemy();  
                collision.gameObject.SetActive(false);  
            }
            else
            {
                collision.gameObject.SetActive(false);
                Destroy(gameObject);
                isDestroyed = true;
                Debug.Log("if true");
            }
        }
    }
}
