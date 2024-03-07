using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROLLING : MonoBehaviour
{
    public float xForce = 5.0f;
    public float yForce = 5.0f;
    public float zForce = 100.0f;

    void Start()
    {

    }

    void Update()
    {
        float x = 0.0f, y = 0.0f, z = 0.0f;
        if (Input.GetKey(KeyCode.S))
        {
            x = x - xForce;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            x = x + xForce;
        }
        if (Input.GetKey(KeyCode.C))
        {
            z = z + zForce;
        }
        if (Input.GetKey(KeyCode.X))
        {
            z = z - zForce;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            y = yForce;
        }
        GetComponent<Rigidbody>().AddForce(x, y, z);

    }
}
