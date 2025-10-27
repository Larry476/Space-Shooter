using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Experimental.GraphView.GraphView;

public class EnemySpawner : MonoBehaviour
{
    [Header("Enemy Spawner")]
    
    public Transform SpawnPoint;
    public GameObject EnemySmallprefab;
    public GameObject Player;
    public int maxenemies = 5;

    private float timer = 0f;
    private float respawninterval = 2f;
    private int minenemies = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= respawninterval && minenemies < maxenemies) 
        {
            spawnenemy();
            timer = 0;
        }
      
        void spawnenemy()
        {
            Instantiate(EnemySmallprefab, SpawnPoint.position, SpawnPoint.rotation);
            minenemies++;
        }
        

       
    }
  


}
