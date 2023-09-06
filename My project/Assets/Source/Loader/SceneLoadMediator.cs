using UnityEngine;
using Zenject;

public class SceneLoadMediator
{
    private ISimpleSceneLoader _simpleLoader;
    private ILevelLoader _levelLoader;

    [Inject]
    private void Construct(ISimpleSceneLoader simpleLoader, ILevelLoader levelLoader)
    {
        _simpleLoader = simpleLoader;
        _levelLoader = levelLoader;
    }

    public void GoToGameplayLevel(IVictory strategy)
    {
        _levelLoader.Load(strategy);
    }

    public void GoToGameModeChooseScene()
    {
        _simpleLoader.Load(SceneID.GameModeChooseScene);
    }
}
