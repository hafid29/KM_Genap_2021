using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string myText;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hello World");
        //Debug.Log("myText");
    }
    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10, 10, 200, 200));
        GUILayout.Label(myText);
        GUILayout.EndArea();
    }
}
