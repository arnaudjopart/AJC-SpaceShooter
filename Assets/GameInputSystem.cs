using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInputSystem : MonoBehaviour
{
    public InputListener m_currentInputListener;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (m_currentInputListener == null) return;
        
        
        
        //m_currentInputListener.HandleInput();
    }

    private Vector2 m_moveVector;
}

public abstract class InputListener : MonoBehaviour
{
    
}
