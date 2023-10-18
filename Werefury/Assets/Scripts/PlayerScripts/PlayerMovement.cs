using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    private GameObject player;
    [SerializeField] public Car car;
    void Awake()
    {
        player = GameObject.FindWithTag("Player");
    }

    void FixedUpdate()
    {
        player = GameObject.FindWithTag("Player");
        rb = player.GetComponent<Rigidbody>();
        if (car._playerIsInCar)
        {
        }
        if (!car._playerIsInCar){
            Walking();
        }
    }
    void Walking()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = movement * speed;
    }
}