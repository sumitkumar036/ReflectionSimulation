using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour
{
    LineRenderer ray;

    // Start is called before the first frame update
    void Start()
    {
        ray = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        ray.SetPosition(0, transform.position);
        ray.SetPosition(1, transform.forward * 5);
    }
}
