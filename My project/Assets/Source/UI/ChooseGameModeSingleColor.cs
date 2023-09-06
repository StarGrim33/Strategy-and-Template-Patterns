using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ChooseGameModeSingleColor : MonoBehaviour
{
    private SceneLoadMediator _mediatorMediator;

    [Inject]
    private void Construct(SceneLoadMediator mediator)
    {
        _mediatorMediator = mediator;
    }

    private readonly Dictionary<Color, string> colorNames = new()
    {
        { Color.red, "Red" },
        { Color.green, "Green" },
        { Color.white, "White" }
    };

    public void ChooseMode()
    {
        Color color = ChooseColorRandomly();
        _mediatorMediator.GoToGameplayLevel(new SingleColorPopStrategy(color));
        Debug.Log($"Requer target is {colorNames[color]}");
    }

    private Color ChooseColorRandomly()
    {
        int randomIndex = Random.Range(0, 3);

        if (randomIndex == 0) return Color.red;
        else if (randomIndex == 1) return Color.green;
        else if (randomIndex == 2) return Color.white;

        return Color.white;
    }
}
