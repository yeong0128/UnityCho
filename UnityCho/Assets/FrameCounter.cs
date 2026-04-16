using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class FrameCounter : MonoBehaviour
{
    private float deltaTime = 0f;

    //[SerializeField] private int size = 25;
    [SerializeField] private Color color = Color.red;

    public Text frameTxt;
    HelloWorld hw;
    Camera cam;
    private int size;

    void Start()
    {
        GameObject go = GameObject.Find("selColOb");
        hw = go.GetComponent<HelloWorld>();
        cam = go.GetComponent<Camera>();
        
    }

    void Update()
    {
        
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
        float ms = deltaTime * 1000f;
        float fps = 1.0f / deltaTime;
        string text = string.Format("(0:0.) FPS({1:0.0} ms)", fps, ms);
        frameTxt.text = text;

        frameTxt.color = color;
    }

    public void chanagCol() 
    {
        
    }


    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();

        Rect rect = new Rect(30, 30, Screen.width, Screen.height);
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = size;
        style.normal.textColor = color;

        float ms = deltaTime * 1000f;
        float fps = 1.0f / deltaTime;
        string text = string.Format("{0:0.} FPS ({1:0.0} ms)", fps, ms);

        GUI.Label(rect, text, style);
    }
}