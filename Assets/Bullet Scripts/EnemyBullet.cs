using System.Collections;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using NUnit.Framework.Internal.Filters;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 35f;
    public int damagePlayer = 5;
    public Rigidbody2D rb; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.linearVelocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D PlayerHit)
    {

        if (PlayerHit.CompareTag("Player"))
        {
            PlayerManager PlayerManager = PlayerHit.GetComponent<PlayerManager>();


            if (PlayerManager != null)
            {
                PlayerManager.EnemyBullet(damagePlayer);
                StartCoroutine(EnemyHitRemove());
            }
            else
            {
                 StartCoroutine(DeleteEnemyBullet());
            }

        }

    }
    private IEnumerator DeleteEnemyBullet()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
    private IEnumerator EnemyHitRemove()
    {
        yield return new WaitForSeconds(0f);
        Destroy(gameObject);
    }
   
    
}


