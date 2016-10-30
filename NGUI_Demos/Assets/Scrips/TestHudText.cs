using UnityEngine;
using System.Collections;

public class TestHudText : MonoBehaviour {


    public HUDText text;




    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            text.Add("-10", Color.red, 1);
        }
    }
}
