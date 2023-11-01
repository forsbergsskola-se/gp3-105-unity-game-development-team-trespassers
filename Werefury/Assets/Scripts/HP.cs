using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    [FormerlySerializedAs("hp")] public int value;

    public WarningText warning;
    // Assuming you have an array of sprites or references to your sprite assets.
    [SerializeField] private Sprite[] spriteArray;
    [SerializeField] private bool TextureChange;
    private SpriteRenderer spriteRenderer;
    private int full;
    private int half;
    private int quarter;
    private void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        full = value / 1;
        half = value / 2;
        quarter = value / 4;
    }

    public int TakeDamage(int damage)
    {
        value -= damage;
        return value;
        //No idea if this will work but i hope.
        
    }

    public int HealDamage(int heal)
    {
        value += heal;
        return value;
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
        if (value <= 0)
        {
            //Countdown
            //Damage Player if still in the car
            Destroy(gameObject); 
        }
        
    }
}
