using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlJoystick : MonoBehaviour
{
    public Joystick Joystick;
    private float _mouseX;
    private float _mouseY;
    public float sens = 100f;
    public Transform Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _mouseX = Joystick.Horizontal * sens * Time.deltaTime;
        _mouseY = Joystick.Vertical * sens * Time.deltaTime;
        
        
        Player.Rotate(_mouseX * new Vector3(0,1,0));
        transform.Rotate(-_mouseY * new Vector3(1,0,0));
    }
}
