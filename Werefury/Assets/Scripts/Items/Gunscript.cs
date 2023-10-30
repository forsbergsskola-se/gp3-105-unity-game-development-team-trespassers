using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Items
{
    

public class Gunscript : MonoBehaviour
{
    // public Projectile projectilePrefab;
    public LayerMask mask;
    public bool triggerViable = true;
    [SerializeField]private float cooldown = 1.5f;
    private float reloadTime = 0f;

    void shoot(GameObject hitSpecific)
    {

        var hit = hitSpecific.GetComponent<HP>();

        if (hit)
        {
            hit.TakeDamage(5);
        }
        
        /*var pointAboveFloor = hit.point + new Vector3(0, this.transform.position.y, 0);

        // 3
        var direction = pointAboveFloor - transform.position;

        // 4
        var shootRay = new Ray(transform.position, direction);
        Debug.DrawRay(shootRay.origin, shootRay.direction * 100.1f, Color.blue, 2);*/

        // 5
        // Physics.IgnoreCollision(GetComponent<Collider>(), projectile.GetComponent<Collider>());

        // 6
        // projectile.FireProjectile(shootRay);
    }
    
    // 1
    public void raycastOnMouseClick () {
        RaycastHit hit;
        Ray rayToFloor = new Ray(transform.position, transform.forward);
        Debug.DrawRay(rayToFloor.origin, rayToFloor.direction * 100.1f, Color.red, 2);

        if(Physics.Raycast(rayToFloor, out hit, 100.0f, mask, QueryTriggerInteraction.Collide) ) {
            var hitSpecific = hit.transform.gameObject;
            Debug.Log(hit.transform.gameObject);
            shoot(hitSpecific);
        }
    }

    public void Reload(Weapon WeaponSpecific)
    {
        triggerViable = false;
        while (Time.time > reloadTime)
        {
            reloadTime = Time.time + cooldown;
        }
        triggerViable = true;
    }

    // Update is called once per frame
    // 2
    void Update () {

    }
}
}