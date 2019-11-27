using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public WheelJoint2D w1, w2;
    public int motorSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        motorSpeed = -100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            w1.useMotor = true;
            w2.useMotor = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            motorSpeed = motorSpeed - 10;
        }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            w1.useMotor = false;
            w2.useMotor = false;
            motorSpeed = motorSpeed + 100;
        }
    }
}
