using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 15;
    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.linearVelocity = transform.up * speed;
   
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
    EnemySmall EnemySmall = hitInfo.GetComponent<EnemySmall>();
        if (EnemySmall != null)
        {
            EnemySmall.TakeDamage(damage);
            
        }
        else
        {
            StartCoroutine(Deletee());
         }
    }

    private IEnumerator Deletee()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }

}
