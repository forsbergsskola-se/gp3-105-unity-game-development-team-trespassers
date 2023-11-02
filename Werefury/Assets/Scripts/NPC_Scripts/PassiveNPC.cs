using UnityEngine;

public class PassiveNPC : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public float movementRange = 5.0f;
    public float changeDirectionTime = 2.0f;
    public float avoidanceDistance = 2.0f; 
    private float timer = 0.0f;
    private Vector3 randomDirection;
    
    void Start()
    {
        GenerateRandomDirection();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= changeDirectionTime)
        {
            GenerateRandomDirection();
            timer = 0.0f;
        }

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, avoidanceDistance))
        {
            randomDirection = -hit.normal;
        }

        transform.Translate(randomDirection.normalized * moveSpeed * Time.deltaTime);
    }

    void GenerateRandomDirection()
    {
        float randomX = Random.Range(-movementRange, movementRange);
        float randomZ = Random.Range(-movementRange, movementRange);
        randomDirection = new Vector3(randomX, 0, randomZ);
    }
}