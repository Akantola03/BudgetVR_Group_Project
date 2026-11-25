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
        else
        {
            foreach (PlanetOrbit p in planets)
            {
                p.isOrbiting = false;
            } 
        }
    }
    
    /*
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (PlanetOrbit p in planets)
            {
                if (p != null)
                {
                   p.isOrbiting = true; 
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (PlanetOrbit p in planets)
            {
                if (p != null)
                {
                   p.isOrbiting = false; 
                }
            }
        }
    }
    */
}