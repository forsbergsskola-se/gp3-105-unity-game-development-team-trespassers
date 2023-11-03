using UnityEngine;
using UnityEngine.PlayerLoop;

namespace PlayerScripts
{
    public class Werewolf : MonoBehaviour
    {
        [SerializeField] public GameObject PlayerSprite;
        [SerializeField] public TimeCycle DayOrNight;
        [SerializeField] public Sprite Human;
        [SerializeField] public Sprite Wolf;
        
        private void Update()
        {
            SpriteRenderer playerSprite = PlayerSprite.GetComponent<SpriteRenderer>();
            if (!DayOrNight.day)
            {
                playerSprite.sprite = Wolf;
                
            }
            else
            {
                playerSprite.sprite = Human;
            }
        }
    }
}