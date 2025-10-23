using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class SpaceShipShoot : MonoBehaviour
{
    public Transform Firepoint;
    public Transform Firepoint2;
    public GameObject bulletprefab;
    public GameObject bulletprefab2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            shoot();
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
