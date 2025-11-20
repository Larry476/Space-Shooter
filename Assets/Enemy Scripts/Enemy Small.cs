using System.Collections;
using System.Collections.Generic;
using System.Threading;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering;


public class EnemySmall : MonoBehaviour
{
    public int scorevalue = 15;
    public int health = 25;

    
    public GameObject EnemyBulletPrefab;
    public Transform EnemyFirepoint;
    public float timer = 0f;
    public float shootDelayE = 1f;
    private float currentCooldown;
    private bool shooting; 

    public GameObject Player;

    public float enemySpeed = 1f;
    public float maxY = 0f;
    public float minY = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   

       
    void Start()
    {
        timer += Time.deltaTime;
        shootDelayE += Time.deltaTime;
   
    }
    // Update is called once per frame

    void Update()
    {
        transform.position += new Vector3(0, -1, 0) * enemySpeed * Time.deltaTime;
        // Moves the enemy towards the player.
        if (shooting == false && timer >= shootDelayE)
        {
            Enemyshoot();
           
            shootDelayE = 1f;
            timer = 1f;
        }
        else if (shooting == true && timer >= shootDelayE)
        {
            
            shootDelayE -= Time.deltaTime;
            timer = 1f;
        }
        // Makes the enemy shoot.

   
    }
 
     public void TakeDamage(int damage)
    { 
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
            ScoreManager.instance.AddScore(scorevalue);
            // Dies and gives score.
        }
        

    }
    public void ExplosionDamage(int ExplosiveDamage)
    {
        health -= ExplosiveDamage;
        if (health <= 0)
        {
            Destroy(gameObject);
            ScoreManager.instance.AddScore(scorevalue * ExplosiveDamage);
            // Gives more score with explosive bullets.
        }
    }
    void Enemyshoot()
    {
        Instantiate(EnemyBulletPrefab, EnemyFirepoint.position, EnemyFirepoint.rotation);
        if (currentCooldown > 0)
        {
            currentCooldown = timer;
            currentCooldown = shootDelayE;
        }

    }
    
    }

