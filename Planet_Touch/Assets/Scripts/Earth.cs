using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    [SerializeField] Planet planetEarth;

    private void Awake()
    {
        GetComponent<Camera>().backgroundColor = planetEarth.GetSkyColor;
        Physics2D.gravity = new Vector2(0, -planetEarth.GetGravity);
    }
}
