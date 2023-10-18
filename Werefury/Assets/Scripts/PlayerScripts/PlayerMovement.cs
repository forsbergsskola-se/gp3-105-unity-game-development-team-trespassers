using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    private GameObject player;
    [SerializeField] public Car car;
    public float horizontalSpeed = 2.0f;
    public float verticalSpeed = 2.0f;
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
        Vector3 mousePointer = new Vector3(Input.mousePosition.x, Input.mousePosition.y);

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = movement * speed;
        Vector3 mousePosition = Input.mousePosition;
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(h, v, 0);
        // Vector3 newRotation = Vector3.RotateTowards(transform.forward, mousePointer, 0.02f, 0.0f);
        // transform.rotation = Quaternion.LookRotation(newRotation);
    }

}