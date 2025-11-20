using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ExplosiveBullet : MonoBehaviour
{
    public float speed = 10f;
    public int ExposiveHit = 30;
    public Rigidbody2D rb;
    public GameObject ExplosionPrefab;
    
    
    void Start()
    {
        rb.linearVelocity = transform.up * speed;
        CompareTag("Bullet Explosive");
        print(tag);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D ExplosiveHit)
    {
        if (ExplosiveHit.CompareTag("Enemy Small"))
        {
            EnemySmall EnemySmall = ExplosiveHit.GetComponent<EnemySmall>();
            if (EnemySmall != null)
            {
                CompareTag("Explosion");
                EnemySmall.ExplosionDamage(ExposiveHit);
                StartCoroutine(Explode());
                // Checks if the tag matches the enemy and explodes if it hits the enemy tag - O
            }
            else
            {
                StartCoroutine(RemoveBullet());
                StartCoroutine(Explode());
            }
            if (ExplosiveHit.CompareTag("Player"))
            {
                CompareTag("Explosion");
                PlayerManager PlayerManager = ExplosiveHit.GetComponent<PlayerManager>();
                if (PlayerManager != null)
                {
                    Debug.Log("Self Damage");
                    PlayerManager.PlayerDamage(ExposiveHit);
                    StartCoroutine(Explode());
                    // Checks if the explosive hits the player. 
                }
                else
                {
                    StartCoroutine(RemoveBullet());
                }
            }

        }
    }

   
    private IEnumerator RemoveBullet()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
    private IEnumerator Explode()
    {
        Instantiate(ExplosionPrefab, transform.position, transform.rotation);
        ExposiveHit++;
        yield return new WaitForSeconds(0f);
        Destroy(gameObject);
    }


}
