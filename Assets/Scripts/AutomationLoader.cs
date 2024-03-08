using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomationLoader : MonoBehaviour
{
    public SceneLoader sceneLoader;
    public string sceneName;
    public float time;
    void Start()
    {
        Invoke("AutoLoad", time);
    }

    void AutoLoad()
    {
        sceneLoader.ChangeScene(sceneName);
    }
}
