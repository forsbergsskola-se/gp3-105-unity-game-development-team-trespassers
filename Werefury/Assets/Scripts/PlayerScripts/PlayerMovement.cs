using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;
    [SerializeField] public Car car;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (!car._playerIsInCar){
            Walking();
            // OnMouseDrag();
        }
    }
    void Walking()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = movement * speed;
    }
    
    /*void OnMouseDrag()
    {
        float turn = 2 * Input.GetAxis("Mouse X");
        transform.Rotate(0, 0, turn);
       
        
    }*/
        
}


