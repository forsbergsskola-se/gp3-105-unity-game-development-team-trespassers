using UnityEngine;

public class HP : MonoBehaviour
{
    public int hp;

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

    private void Update()
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
        else if (hp == 0)

            if (hp <= 0)
            {
                //Countdown
                //Damage Player if still in the car
                Destroy(this.gameObject);
            }
    }
}
