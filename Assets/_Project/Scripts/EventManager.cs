using UnityEngine;

public class EventManager : MonoBehaviour
{
    private static EventManager m_instance;

    private void Awake()
    {
        m_instance = this;
        m_onAllScenesLoadedEvent = new SceneLoadingEvent();
    }

    public static void OnScenesLoaded()
    {
        m_instance.m_onAllScenesLoadedEvent.Invoke("");
    }

    private SceneLoadingEvent m_onAllScenesLoadedEvent;
}