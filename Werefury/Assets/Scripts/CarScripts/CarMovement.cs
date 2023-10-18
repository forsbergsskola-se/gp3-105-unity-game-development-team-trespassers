using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 0.5f;
    public Rigidbody rb;
    // Update is called once per frame
    void Update()
    {
        void RotateCar()
        {
            //How rotate head of the car?
            float rotation = Input.GetAxis("Vertical");
        
            Vector3 movementOutput = new Vector3(0, rotation, 0);
            rb.velocity = movementOutput * speed;
        }
    }
}
