using UnityEngine;

public class PlanetRotate : MonoBehaviour
{
    public float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        // Spin the object around it's axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
