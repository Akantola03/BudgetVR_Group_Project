using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlanetMovenemt : MonoBehaviour
{
    public GameObject orbitAround;
    public float orbitingSpeed;
    public float selfRotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Spin the object around it's axis
        transform.Rotate(Vector3.up, selfRotationSpeed * Time.deltaTime);

        // Rotate the object around the target at 20 degrees per second
        transform.RotateAround(orbitAround.transform.position, Vector3.up, orbitingSpeed * Time.deltaTime);

    }
}
