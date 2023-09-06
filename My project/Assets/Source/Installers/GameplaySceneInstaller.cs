using UnityEngine;
using Zenject;

public class GameplaySceneInstaller : MonoInstaller
{
    private IVictory _victoryStrategy;

    [Inject]
    private void Construct(IVictory strategy)
    {
        _victoryStrategy = strategy;
    }

    public override void InstallBindings()
    {
        if (_victoryStrategy is AllBallsPopStrategy)
            Container.Bind<IVictory>().To<AllBallsPopStrategy>().AsSingle();
        else if (_victoryStrategy is SingleColorPopStrategy)
            Container.Bind<IVictory>().To<SingleColorPopStrategy>().AsSingle()
                        .WithArguments(((SingleColorPopStrategy)_victoryStrategy).Color);
    }
}