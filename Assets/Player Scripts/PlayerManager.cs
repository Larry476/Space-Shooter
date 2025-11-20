using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    [Header("Boundary Limits")]
    [SerializeField] float minX = -17.4f;
    [SerializeField] float maxX = 17.4f;
    [SerializeField] float minY = -9.5f;
    [SerializeField] float maxY = 9.5f;

    [SerializeField, Range(8.5f, 15)] float speed;
    [SerializeField] KeyCode left = KeyCode.A;
    [SerializeField] KeyCode right = KeyCode.D;
    [SerializeField] KeyCode up = KeyCode.W;
    [SerializeField] KeyCode down = KeyCode.S;
    public GameObject Player;
    public int PlayerHealth = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(right))
        {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(up))
        {
            transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(down))
        {
            transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
            // The basic player movement. Player can move Up, Down, Left and Right. 
        }


        Vector3 clampedPos = transform.position;
        clampedPos.x = Mathf.Clamp(clampedPos.x, minX, maxX);
        clampedPos.y = Mathf.Clamp(clampedPos.y, minY, maxY);
        transform.position = clampedPos;
        // Stops the player from going out of bounds. 
    }

    public void EnemyBullet(int Playerdamage)
    {
        PlayerHealth -= Playerdamage;
        if(PlayerHealth < 0)
        {
            Destroy(gameObject);
        }
    }
    public void PlayerDamage(int explosiveDamage)
    {
        PlayerHealth -= explosiveDamage;
        if (PlayerHealth < 0)
        {
            print(PlayerHealth);
            Destroy(gameObject);
        }
        // The player dies if they either get hit by a enemy bullet or an explosive if they have low enough HP.
    }

}