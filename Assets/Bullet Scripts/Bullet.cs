using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 15;
    public Rigidbody2D rb;
    public int scorevalue = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CompareTag("Bullet");
        rb.linearVelocity = transform.up * speed;
    }
    void Update()
    {
        
        
        
    }


    private void OnTriggerEnter2D(Collider2D CollisionHit)
    {
        if (CollisionHit.CompareTag("Enemy Small"))
        {
            
               EnemySmall EnemySmall = CollisionHit.GetComponent<EnemySmall>();
                if (EnemySmall != null)
                {
                    EnemySmall.TakeDamage(damage);
                    StartCoroutine(HitRemove());
                    ScoreManager.instance.AddScore(scorevalue);
                }
                else
                {
                    StartCoroutine(Deletee());
                }

            }
        }
        
           
    private IEnumerator Deletee()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
    private IEnumerator HitRemove()
    {
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }


}
