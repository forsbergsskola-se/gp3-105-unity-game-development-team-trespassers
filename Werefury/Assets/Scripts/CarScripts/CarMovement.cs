using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float rotationSpeed = 25f;
    public float movementSpeed = 5f;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        RotateCar();
        void RotateCar()
        {
            //How rotate head of the car?
            float rotation = Input.GetAxis("Horizontal")*rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up, rotation);
        }
        moveCar();
        void moveCar()
        {
            float movement = Input.GetAxis("Vertical");
            Vector3 moveDirection = transform.forward * movement * movementSpeed * Time.deltaTime;
            transform.position += moveDirection;
        }
    }
}
