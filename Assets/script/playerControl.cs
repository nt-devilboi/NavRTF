using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Скорость перемещения")] public float speed;
    [SerializeField]
    private  FixedJoystick _joystick;

    private float horizontal;
    private float vertical;
    [SerializeField]
    private  Rigidbody _rb;
    // Update is called once per frame
    void Update()
    {
        GetInput();
    }
    

    private void GetInput()
    {
        vertical = _joystick.Vertical;
        horizontal = _joystick.Horizontal;
        
        if (horizontal >= 0.5)
            transform.localPosition += transform.right * speed * Time.deltaTime;
        
        if (horizontal <= -0.5)
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        
        if (vertical >= 0.5f)
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        
        if (vertical <= -0.5f)
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
    }
}