using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contol : MonoBehaviour
{
    // Start is called before the first frame update
    private  float _mouseX;
    private  float _mouseY;
    [Header("чувстивительность мыши")] public float sensMouse = 200f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    /*void Update()
    {
        _mouseX = Input.GetAxis("Mouse X") * se
    }*/
}
