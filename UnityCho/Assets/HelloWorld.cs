using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    public Camera cam;
    public Camera cam1;
    public Color pickCol;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam.fieldOfView = 120f;
        cam1.fieldOfView = 10f;
        Debug.Log("Hello World!!");
        
    }

    // Update is called once per frame
    void Update()
    {
        cam1.fieldOfView += 0.1f;
        pickCol = getCol();
    }

    Color getCol() 
    {
        return Color.blue;
    }
}
