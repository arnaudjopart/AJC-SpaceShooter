using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class ShipRotation : MonoBehaviour
{
    public float m_angularAcceleration;

    public float m_currentAngularSpeed;

    public float m_maxAngularSpeed;

    public float m_angularDrag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput(ref m_rightAngularSpeed, Keyboard.current.aKey);
        HandleInput(ref m_leftAngularSpeed, Keyboard.current.dKey);

        m_currentAngularSpeed = -m_rightAngularSpeed + m_leftAngularSpeed;
        
        transform.rotation*= Quaternion.Euler(0,0,m_currentAngularSpeed);
    }

    private void HandleInput(ref float _angularSpeed, KeyControl _keyCode)
    {
        if (_keyCode.isPressed)
        {
            _angularSpeed += m_angularAcceleration*Time.deltaTime;
            _angularSpeed = Mathf.Min(_angularSpeed, m_maxAngularSpeed);
        }
        else
        {
            _angularSpeed -= m_angularDrag * Time.deltaTime;
            _angularSpeed = Mathf.Max(_angularSpeed, 0);
        }
    }
    
    private float m_leftAngularSpeed;
    private float m_rightAngularSpeed;
}
