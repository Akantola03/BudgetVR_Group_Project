using UnityEngine;

public class CustomInterraction : Interactive
{

    int sizeMultiplier = -1;

    public new void Interact() 
    {
        sizeMultiplier *= -1;

        //gameObject.GetComponent<Renderer>().material.color = Color.red;
        gameObject.transform.localScale += new Vector3(sizeMultiplier * 2, sizeMultiplier * 2, sizeMultiplier * 2);


    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int sizeMultiplier = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
