using UnityEngine;

public class OrbitingTrigger : MonoBehaviour
{
    public GameObject viewPoint;
    public PlanetOrbit[] planets;

    private void Update()
    {
        if (CameraInteract.GetPlayerTransform().position == viewPoint.transform.position)
        {
            foreach (PlanetOrbit p in planets)
            {
                p.isOrbiting = true;
            }
        }
    }

    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Default"))
        {
            foreach (PlanetOrbit p in planets)
            {
                p.isOrbiting = true;
            }

        }
    }
    */
}