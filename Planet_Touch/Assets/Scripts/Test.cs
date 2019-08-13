using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
