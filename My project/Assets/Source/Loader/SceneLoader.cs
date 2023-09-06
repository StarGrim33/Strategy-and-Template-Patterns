using System;

public class SceneLoader : ISimpleSceneLoader, ILevelLoader
{
    private ZenjectSceneLoaderWrapper _loader;

    public SceneLoader(ZenjectSceneLoaderWrapper wrapper)
    {
        _loader = wrapper;
    }

    public void Load(SceneID sceneID)
    {
        if (sceneID == SceneID.GameplayScene)
            throw new ArgumentException($"{SceneID.GameplayScene} cannot be started whithout configuration");

       _loader.Load(null, (int)sceneID);
    }

    public void Load(IVictory strategy)
    {
        _loader.Load(container =>
        {
            container.BindInstance(strategy).WhenInjectedInto<GameplaySceneInstaller>();
        }, (int)SceneID.GameplayScene);
    }
}
