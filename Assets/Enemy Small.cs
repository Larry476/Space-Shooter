using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class EnemySmall : MonoBehaviour
{
    public int health = 25;
    public GameObject Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
        void Start()
    {
        print(health);
    }
       // Update is called once per frame

    void Update()
    {
        transform.position = new Vector3 (0, 0);
        if(health < 35)
        {
            
        }


    }
     public void TakeDamage(int damage)
    {
        print(health);
        health -= damage;
        if (health <= 0)
        {
            print(health);
            Destroy(gameObject);
        }

    }
}
