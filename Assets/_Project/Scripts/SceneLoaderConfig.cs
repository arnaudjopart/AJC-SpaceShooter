using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/SceneConfig file")]
public class SceneLoaderConfig : ScriptableObject
{
    public List<string> m_scenesList;
}