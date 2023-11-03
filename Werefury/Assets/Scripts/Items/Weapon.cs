using System;
using UnityEngine;
using Input = UnityEngine.Windows.Input;

namespace Items
{
    
public class Weapon : MonoBehaviour
{
    [SerializeField] public string weaponId;
    [SerializeField] public int damage;
    [SerializeField] public int mag;
    [SerializeField] public int magMax;
    public bool isShooting;
    private void Start()
    {
        mag = magMax;
    }
}
}