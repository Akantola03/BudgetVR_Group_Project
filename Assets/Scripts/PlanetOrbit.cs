using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlanetOrbit : MonoBehaviour
{
    public GameObject orbitAround;
    public float orbitingSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around the target at 20 degrees per second
        transform.RotateAround(orbitAround.transform.position, Vector3.up, orbitingSpeed * Time.deltaTime);

    }
}
