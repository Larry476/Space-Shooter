using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class SpaceShipShoot : MonoBehaviour
{
    public Transform Firepoint;
    public Transform Firepoint2;
    public GameObject bulletprefab;
    public GameObject bulletprefab2;
    public GameObject ExplosiveBulletprefab;
    // Bullet Prefabs finding - Oliver
    public float shootDelay = 0.5f;
    private float timer = 0.7f;
    public float explosiveDelay = 5f;
    private float explosiveTimer = 3f;
    
    // The shooting delay for each bullet type - Oliver
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        explosiveTimer += Time.deltaTime;

        if (Input.GetKey(KeyCode.E) && timer >= shootDelay)
        {
            shoot();
            timer = 1f;
        
        }
        if(Input.GetKey(KeyCode.Q) && explosiveTimer >= explosiveDelay )
        {
            ExplosiveShoot();
            explosiveTimer = 3f;
            
        }

    }
    void shoot()
    {
        Instantiate(bulletprefab, Firepoint.position, Firepoint.rotation);
        Instantiate(bulletprefab2, Firepoint2.position, Firepoint2.rotation);
    }
    void ExplosiveShoot()
    {
        Instantiate(ExplosiveBulletprefab, Firepoint.position, Firepoint.rotation);
    }
 

}