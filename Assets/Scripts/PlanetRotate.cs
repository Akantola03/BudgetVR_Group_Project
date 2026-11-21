using UnityEngine;

public class PlanetRotate : MonoBehaviour
{
    public float RotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Spin the object around it's axis
        transform.Rotate(Vector3.up, RotationSpeed * Time.deltaTime);
    }
}
