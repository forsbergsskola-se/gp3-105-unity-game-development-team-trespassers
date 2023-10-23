using UnityEngine;


public class PlayerAim : MonoBehaviour
{
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out var hitInfo);
        Vector3 target = hitInfo.point;
        target.y = transform.position.y;
        transform.LookAt(target, Vector3.up);
        Debug.DrawRay(ray.origin, ray.direction * 100.1f, Color.green, 2);
    }
}