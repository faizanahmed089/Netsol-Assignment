using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject enemy = null;
    public Slider enemyHealth;

    public static GameManager Instance { get; set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    // Create attack emthod with two parameters. When bullet hit enemy health decreases and damage of 33.33
    // Enemy is not destroy first attemp. It will destroy at third attempt
    public void Attack(GameObject enemy, float damage)
    {
        enemyHealth.value -= damage; 
    }

    public void BulletCollideWithEnemy()
    {
        Attack(enemy, 33.33f);
    }
}
