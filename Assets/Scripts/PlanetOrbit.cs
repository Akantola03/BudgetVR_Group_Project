using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlanetOrbit : MonoBehaviour
{
    public GameObject orbitAround;
    public float orbitingSpeed;

    public bool isOrbiting = false;

    // Update is called once per frame
    void Update()
    {
        if (isOrbiting)
        {
            // Rotate the object around the target at 20 degrees per second
            transform.RotateAround(
                orbitAround.transform.position, 
                Vector3.up, 
                orbitingSpeed * Time.deltaTime);
        }
    }
}
