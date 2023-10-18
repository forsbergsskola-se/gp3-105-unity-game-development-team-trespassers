using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private GameObject cameraObject;
    private Transform cameraPos;
    private Vector3 currentVelocity;
    [SerializeField] private float smoothTime = 0.3f;

    void Awake()
    {
        GameObject CameraPosObject = GameObject.Find("CameraPos");
        cameraPos = CameraPosObject.transform;
    }
    
    void FixedUpdate()
    {

        cameraObject.transform.position = Vector3.SmoothDamp(
            cameraObject.transform.position,
            new Vector3(cameraPos.position.x, cameraPos.position.y, cameraPos.position.z),
            ref currentVelocity,
            smoothTime
        );
    }
}

