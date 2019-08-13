using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Planet", menuName ="Planet")]
public class Planet : ScriptableObject
{
    [SerializeField] float gravitySpeed;
    [SerializeField] Color skyColor;

    public Color GetSkyColor
    {
        get { return skyColor; }
    }

    public float GetGravity
    {
        get { return gravitySpeed; }
    }
}
