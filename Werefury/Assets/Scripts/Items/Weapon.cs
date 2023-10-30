using UnityEngine;

namespace Items
{
    
public class Weapon : MonoBehaviour
{
    [SerializeField] public string weaponId;
    [SerializeField] public int damage;
    [SerializeField] public int mag;
    [SerializeField] public int magMax;
}
}