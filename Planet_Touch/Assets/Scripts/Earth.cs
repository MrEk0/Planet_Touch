using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    [SerializeField] Planet planetEarth;

    private void Awake()
    {
        GetComponent<Camera>().backgroundColor = planetEarth.GetSkyColor;
    }
}
