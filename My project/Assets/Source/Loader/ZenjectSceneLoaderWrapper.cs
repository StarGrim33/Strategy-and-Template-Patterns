using System;
using UnityEngine;
using Zenject;

public class ZenjectSceneLoaderWrapper
{
    private readonly ZenjectSceneLoader _loader;

    [Inject]
    public ZenjectSceneLoaderWrapper(ZenjectSceneLoader loader)
    {
        _loader = loader;
    }

    public void Load(Action<DiContainer> action, int sceneID)
    {
        _loader.LoadScene(sceneID, UnityEngine.SceneManagement.LoadSceneMode.Single, container  => action?.Invoke(container));
    }
}
