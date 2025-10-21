using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemySmall : MonoBehaviour
{
    public int health = 25;
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
        void Start()
    {
        
    }
       // Update is called once per frame

    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0)
        {
            Die();
        }
        void Die()
        {
            StartCoroutine(Death());
            Destroy(gameObject);
        }
        IEnumerator Death()
        {
            yield return new WaitForSeconds(0.5f);
            Destroy(gameObject);
        }
    }
}
