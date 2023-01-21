using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorchange : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Debug.Log("1");
            GetComponent<Renderer>().material.color = GetRandomColor();
        }
    }

    private Color GetRandomColor()
    {
        return new Color(UnityEngine.Random.Range(0, 1f), 
            UnityEngine.Random.Range(0, 1f), 
            UnityEngine.Random.Range(0, 1f));
    }
}
