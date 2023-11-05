using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManagerFix : MonoBehaviour
{
    public float zSpeed =5.5f;
    public float maksZspeed = 20;
    private CharacterController controller;
    private Vector3 direction;
    public static float forwardSpeed = 8f;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        direction.z = forwardSpeed;
        if (zSpeed < maksZspeed)
        {
            zSpeed += 0.2f * Time.deltaTime;


        }
        if(zSpeed==maksZspeed)
        {
            zSpeed = 20;
        }
        
        direction.z = zSpeed;

    }
    private void FixedUpdate()
    {
        controller.Move(direction * Time.fixedDeltaTime);
    }


}
