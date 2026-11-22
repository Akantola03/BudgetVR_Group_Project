using UnityEngine;

public class TeleportToButton : Interactive
{
    public GameObject teleportPoint;
    private Vector3 pointPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pointPosition = teleportPoint.transform.position;
    }

    public new void Interact()
    { 
        CameraInteract.GetPlayerTransform().position = pointPosition;
    }

    // Method for the UI Button
    public void Teleport()
    {
        Interact();
    }
}
