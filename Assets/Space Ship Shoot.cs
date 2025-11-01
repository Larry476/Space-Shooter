using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class SpaceShipShoot : MonoBehaviour
{
    public Transform Firepoint;
    public Transform Firepoint2;
    public GameObject bulletprefab;
    public GameObject bulletprefab2;
    public float shootDelay = 0.5f;
    private float timer = 0.7f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.E) && timer >= shootDelay)
        {
            shoot();
            timer = 1f;
        }

    }
    void shoot()
    {
        Instantiate(bulletprefab, Firepoint.position, Firepoint.rotation);
        Instantiate(bulletprefab2, Firepoint2.position, Firepoint2.rotation);
    }
 

}
