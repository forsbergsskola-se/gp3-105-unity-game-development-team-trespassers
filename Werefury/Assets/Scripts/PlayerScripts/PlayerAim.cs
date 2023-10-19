using UnityEngine;


public class PlayerAim : MonoBehaviour
{
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out var hitInfo);
        Vector3 target = hitInfo.point;
        target.y = transform.position.y;
        Debug.Log(hitInfo.point);
        Debug.Log(transform.position);
        transform.LookAt(target, Vector3.up);
    }
}