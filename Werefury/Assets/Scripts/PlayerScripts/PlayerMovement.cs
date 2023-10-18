using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    private Car car; 
    public float speed;
    public Rigidbody rb;
    private GameObject player;
    void Awake()
    {
        player = GameObject.FindWithTag("Player");
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        player = GameObject.FindWithTag("Player");
        rb = player.GetComponent<Rigidbody>();
        if (car._playerIsInCar)
        {
            
        }
        if (!car._playerIsInCar){

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = movement * speed;
        }
    }

}