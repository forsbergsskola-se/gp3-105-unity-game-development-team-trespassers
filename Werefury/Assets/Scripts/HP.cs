using CarScripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HP : MonoBehaviour
{
    public int hp;

    public WarningText warning;
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
    private void Start()
    {
        if (car == null)
        {
            GetComponent<Car>();
        }
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        full = hp / 1;
        half = hp / 2;
        quarter = hp / 4;
    }

    public int TakeDamage(int damage)
    {
        hp -= damage;
        return hp;
        //No idea if this will work but i hope.
        
    }

    public int HealDamage(int heal)
    {
        hp += heal;
        return hp;
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
            if (hp >= full)
            {
                spriteRenderer.sprite = spriteArray[0];
            }
            else if (hp <= half)
            {
                spriteRenderer.sprite = spriteArray[1];
            }
            else if (hp <= quarter)
            {
                spriteRenderer.sprite = spriteArray[2];
            }
        }
        
       if (hp == 0)
        {
            if (car != null)
            {
            if (car._playerIsInCar == true)
            {
                Debug.Log("car died");
                carDeath = true;
                playerHP.hp -= 25;
            }
            }
            
            Debug.Log("GameObject destroyed");
            StartCoroutine("CarDeath");


        }
            
     
        
    }
}
