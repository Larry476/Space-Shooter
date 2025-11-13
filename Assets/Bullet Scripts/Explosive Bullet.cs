using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ExplosiveBullet : MonoBehaviour
{
    public float speed = 10f;
    public int ExposiveDamage = 30;
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
                EnemySmall.ExplosionDamage(ExposiveDamage);
                StartCoroutine(Explode());
            }
            else
            {
                StartCoroutine(RemoveBullet());
                StartCoroutine(Explode());
            }
            if (ExplosiveHit.CompareTag("Player"))
            {
                PlayerManager playerManager = ExplosiveHit.GetComponent<PlayerManager>();
                if (playerManager != null)
                {
                    playerManager.PlayerDamage(ExposiveDamage);
                    StartCoroutine (Explode());
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
        ExposiveDamage++;
        yield return new WaitForSeconds(0f);
        Destroy(gameObject);
    }


}
