using UnityEngine;

namespace CarScripts
{
    public class CarMovement : MonoBehaviour
    {
        [SerializeField] private float rotationSpeed = 25f;
        [SerializeField] private float maxSpeed = 10f; 
        [SerializeField] private float acceleration = 2.0f; 
        [SerializeField] private float brakeDeacceleration = 5.0f; 
        [SerializeField] private float brakeAcceleration = 5.0f; 
        [SerializeField] private Car car;
        [SerializeField] private HP hp;

        private Rigidbody rb;
        private float currentSpeed = 0f;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Building"))
            {
                Debug.Log("This is damage");
                currentSpeed = 0f;
                hp.TakeDamage(10);
            }
        }

        void FixedUpdate()
        {
            if (car._playerIsInCar)
            {
                RotateCar();
                MoveCar();
            }
        }

        private void RotateCar()
        {
            float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up, rotation);
        }

        private void MoveCar()
        {
            float movement = Input.GetAxis("Vertical");
            float targetSpeed = movement * maxSpeed;

            if (Input.GetKey(KeyCode.Space))
            {
                if (currentSpeed >= 0)
                {
                    currentSpeed -= brakeDeacceleration * Time.deltaTime;
                }

                if (currentSpeed <= 0)
                {
                    currentSpeed += brakeAcceleration * Time.deltaTime;
                }
            }
            else
            {
                if (movement > 0 && targetSpeed > currentSpeed)
                {
                    currentSpeed += acceleration * Time.deltaTime;
                }
                else if (movement < 0 && targetSpeed < currentSpeed)
                {
                    currentSpeed -= acceleration * Time.deltaTime; 
                }
            }
        
            currentSpeed = Mathf.Clamp(currentSpeed, -maxSpeed, maxSpeed);

            Vector3 moveDirection = transform.forward * currentSpeed * Time.deltaTime;
            rb.MovePosition(transform.position + moveDirection);
        }
    }
}
