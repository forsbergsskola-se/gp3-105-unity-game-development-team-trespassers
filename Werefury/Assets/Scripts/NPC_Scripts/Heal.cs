using System;
using System.Collections;
using System.Collections.Generic;
using PlayerScripts;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] public PlayerHealth hp;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        hp.HealDamage(10);
        Destroy(this.gameObject);
    }
}
