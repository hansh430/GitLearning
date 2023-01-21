using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("1");
            transform.localScale = GetRandomScale();
        }
    }

    private Vector3 GetRandomScale()
    {
        return new Vector3(UnityEngine.Random.Range(0, 5f),
            UnityEngine.Random.Range(0, 5f),
            UnityEngine.Random.Range(0, 5f));
    }
}
