using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initiation : MonoBehaviour
{
    [SerializeField] GameObject gameManager;

    private void Start()
    {
        Instantiate(gameManager, transform);
    }
}
