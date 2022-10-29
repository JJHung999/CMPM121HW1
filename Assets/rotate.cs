using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float xAngle, yAngle, zAngle;

    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle, Space.Self);

    }
}
