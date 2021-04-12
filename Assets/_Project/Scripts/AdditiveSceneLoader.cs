using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class AdditiveSceneLoader : MonoBehaviour
{
    public SceneLoaderConfig m_sceneLoaderConfig;
    
    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        foreach (var sceneName in m_sceneLoaderConfig.m_scenesList)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        }
        EventManager.OnScenesLoaded();
    }
}


public class SceneLoadingEvent : UnityEvent<string>{}