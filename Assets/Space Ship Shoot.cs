using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class SpaceShipShoot : MonoBehaviour
{
    public Transform Firepoint;
    public Transform Firepoint2;
    public GameObject bulletprefab;
    public GameObject bulletprefab2;
    public int shootDelay = 3;
    private float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            timer += Time.deltaTime;
            shoot();
            timer = 0;
        }
        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            
        }

    }
    void shoot()
    {
        Instantiate(bulletprefab, Firepoint.position, Firepoint.rotation);
        Instantiate(bulletprefab2, Firepoint2.position, Firepoint2.rotation);
    }
 

}
