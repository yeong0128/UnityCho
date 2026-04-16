using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class ArrayCont : MonoBehaviour
{

    public string[] names;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i <= names.Length-1; i++) {
            Debug.Log("["+i+"]"+names[i]);
        }
        
    }

    public void addNAme(string name)
    {
        //names.AddRange(name);
        names[5] = name;    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
