using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class EnemySmall : MonoBehaviour
{
    public int scorevalue = 15;
    public int health = 25;
    public GameObject Player;
    public float enemySpeed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   

       
    void Start()
    {
        print(health);
        print(enemySpeed);
    }
       // Update is called once per frame

    void Update()
    {

        transform.position += new Vector3(0, -1, 0) * enemySpeed * Time.deltaTime;
        
    }
     public void TakeDamage(int damage)
    {
        print(health);
        health -= damage;
        if (health <= 0)
        {
            print(health);
            Destroy(gameObject);
            ScoreManager.instance.AddScore(scorevalue);
        }

    }
}
