using UnityEngine;

public class testing : MonoBehaviour
{
    [SerializeField, Range(9.5f, 15)] float speed;
    [SerializeField] KeyCode left = KeyCode.A;
    [SerializeField] KeyCode right = KeyCode.D;
    [SerializeField] KeyCode up = KeyCode.W;
    [SerializeField]KeyCode down = KeyCode.S;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            print("left");
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(right))
        {
            print("right");
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(up))
        {
            transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(down))
        {
            transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
        }
    }
}
