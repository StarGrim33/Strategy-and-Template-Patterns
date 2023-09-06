using UnityEngine;
using Zenject;

public class ChooseGameModePopAllBall : MonoBehaviour
{
    private SceneLoadMediator _mediatorMediator;

    [Inject]
    private void Construct(SceneLoadMediator sceneLoadMediator)
    {
        _mediatorMediator = sceneLoadMediator;
    }

    public void ChooseMode()
    {
        _mediatorMediator.GoToGameplayLevel(new AllBallsPopStrategy());
    }
}
