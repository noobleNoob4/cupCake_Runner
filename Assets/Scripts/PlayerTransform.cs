using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransform : MonoBehaviour
{
    public float rotationSpeed = 50;
    void Update()
    {
        transform.Rotate(0,rotationSpeed * Time.deltaTime,0);
        
    }

}
