using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.EventSystems;
public class MobileInputController : MonoBehaviour
{


    //Car Speed Movement
    public float speed = 10.0F;
    //Left Right Car Movement Speed
    public float rotationSpeed = 100.0F;
    public VariableJoystick j;

    void Update()
    {
        //Get Joystick Control
        float translation = j.Vertical * speed;
        float rotation = j.Horizontal * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }
}