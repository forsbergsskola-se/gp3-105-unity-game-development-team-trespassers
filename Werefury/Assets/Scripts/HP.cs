using CarScripts;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using System.Collections;

public class HP : MonoBehaviour
{
    [FormerlySerializedAs("hp")] public int value;

    // Assuming you have an array of sprites or references to your sprite assets.
    [SerializeField] private Sprite[] spriteArray;
    [SerializeField] private bool TextureChange;
    [SerializeField] private Car car;
    [SerializeField] private HP playerHP;
    public bool carDeath = false;
    private SpriteRenderer spriteRenderer;
    private int full;
    private int half;
    private int quarter;
    public GameObject particlePrefab;
    private void Start()
    {
        if (car == null)
        {
            GetComponent<Car>();
        }
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        full = value / 1;
        half = value / 2;
        quarter = value / 4;
    }

    public int TakeDamage(int damage)
    {
        value -= damage;

        if (value <= 0)
        {
            if (particlePrefab != null)
            {
                Debug.Log("Spawn particle.");
                GameObject particleInstance = Instantiate(particlePrefab, transform.position, particlePrefab.transform.rotation);
                particleInstance.GetComponent<ParticleSystem>().Play();
            }
            // spawn particle
        }
        
        return value;
        //No idea if this will work but i hope.
        
    }

    public int HealDamage(int heal)
    {
        value += heal;
        return value;
    }
    
    private IEnumerator CarDeath()
    {
        yield return new WaitForSeconds(0.1f); // Wait for 3 seconds

        Destroy(this.gameObject);
    }

    void Update()
    {
        if (TextureChange == true)
        {
            if (value >= full)
            {
                spriteRenderer.sprite = spriteArray[0];
            }
            else if (value <= half)
            {
                spriteRenderer.sprite = spriteArray[1];
            }
            else if (value <= quarter)
            {
                spriteRenderer.sprite = spriteArray[2];
            }
        }
        
       if (value == 0)
        {
            if (car != null)
            {
            if (car._playerIsInCar == true)
            {
                Debug.Log("car died");
                carDeath = true;
                playerHP.value -= 25;
            }
            }
            
            Debug.Log("GameObject destroyed");
            StartCoroutine("CarDeath");


        }
            
     
        
    }
}
