using UnityEngine;

public class TeleportToPoint : Interactive
{
    public GameObject teleportPoint;
    private Vector3 pointPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        // Get the coordinates of the teleport point
        pointPosition = teleportPoint.transform.position;
    }

    public new void Interact()
    {
        RaycastHit hit = CameraInteract.GetLatestHit();
        CameraInteract.GetPlayerTransform().position = pointPosition;
    }
}


