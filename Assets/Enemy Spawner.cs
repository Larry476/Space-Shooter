using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Experimental.GraphView.GraphView;

public class EnemySpawner : MonoBehaviour
{
    public float Respawndelay = 5f;
    public Transform SpawnPoint;
    public GameObject EnemySmallprefab;
    public GameObject Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(EnemySmallprefab != null) 
        {
            spawnenemy();
            
        }
        void spawnenemy()
        {
            
            Instantiate(EnemySmallprefab, SpawnPoint.position, SpawnPoint.rotation);

        }
        

       
    }
  


}
