using System.Security.Cryptography;
using UnityEngine;

public class HP : MonoBehaviour
{
    public int hp;
    
    private void Start()
    {
        Transform BilArea = this.transform;
        //Sprite Fire = SOMETHINGSOMETHIN
        // Gör spriterenderer input och sedan change dom. Kanske göra en variable som är serializable för ny input eller eld input?
        //SpriteRenderer
    }
    private void Update()
    {
        if (hp == 100)
        {
            //Instantiate(fire);
        }
        else if (hp == 50)
        {
           
        }
        else if (hp == 0)
        {
            Destroy(this.gameObject);
        }
        
    }
}
