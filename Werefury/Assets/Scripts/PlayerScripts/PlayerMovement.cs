
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
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        rb.velocity = movement * speed;
        OnMouseDrag();

        
    }

    void OnMouseDrag()
    {
        float turn = 2 * Input.GetAxis("Mouse X");
        transform.Rotate(0, 0, turn);
        // Vector3 newRotation = Vector3.RotateTowards(transform.forward, mousePointer, 0.02f, 0.0f);
        // transform.rotation = Quaternion.LookRotation(newRotation);
        
    }

    

}