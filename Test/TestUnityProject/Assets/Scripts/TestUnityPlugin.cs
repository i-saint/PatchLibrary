using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class TestUnityPlugin : MonoBehaviour
{
    [DllImport("TestUnityPlugin")]
    public static extern int TestFunction();
    
    void Update()
    {
        if (Time.frameCount % 30 == 0)
        {
            Debug.Log("TestFunction: " + TestFunction());
        }
    }
}
