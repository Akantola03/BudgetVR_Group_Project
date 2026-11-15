using UnityEngine;

public class ChangeObjectColor : Interactive
{
    private bool isChanged = false;
    private Color originalColor;
    public new void Interact()
    {
        //gameObject.GetComponent<Renderer>().material.color = Color.red;

        Renderer renderer = GetComponent<Renderer>();

        if (!isChanged)
        {
            renderer.material.color = Color.red;
            isChanged = true;
        }
        else
        {
            renderer.material.color = originalColor;
            isChanged = false;
        }

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalColor = GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
