using System.Diagnostics.Contracts;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    public int explosiveDamage = 30;
    public int scorevalue = 5;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 0.25f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy Small"))
        {
            EnemySmall EnemySmall = collision.GetComponent<EnemySmall>();
            if (EnemySmall != null)
            {
                print(explosiveDamage);
                EnemySmall.TakeDamage(explosiveDamage);
                ScoreManager.instance.AddScore(scorevalue);
            }
           
        }
        if (collision.CompareTag("Player"))
        {
            PlayerManager playerManager = collision.GetComponent<PlayerManager>();
            if (playerManager != null)
            {
                playerManager.PlayerDamage(explosiveDamage);
            }
        }
    }
}
