# Exp02-RollABall

## Aim :

To develop a 3D application for RollABall in unity.

## Algorithm :

### Step1 :
Create a new project.

### Step 2 :
Click Heirarchy -> 3D object -> Select the plane -> 3DObject -> Sphere.

### Step 3 :
Define the physics properties of the surface (Rigidbody).

### Step 4 :
Assets -> Create -> # Script

### Step 5 :
Create a folder name Coding and create a C# file to add the coding in it.

### Step 6 :
To add our C# Script file to our selected object, click on the C# Script file and drag it to our selected objects in the Hierarchy window nad run the application.

### Step 7 :
Stop.

### Program :

```
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

```
## Output :
![image](https://github.com/ShyamKumar-AI-DS/Exp02-RollABall/assets/93427182/033df2ed-1cc8-4a98-9a3b-627a76b164b4)


## Result :
Thus a 3D application for roll a ball objects in unity is developed successfully.
