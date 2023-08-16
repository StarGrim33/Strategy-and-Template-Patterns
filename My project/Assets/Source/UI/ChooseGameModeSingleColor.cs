using System.Collections.Generic;
using UnityEngine;

public class ChooseGameModeSingleColor : MonoBehaviour
{
    [SerializeField] private Game _game;

    private readonly Dictionary<Color, string> colorNames = new Dictionary<Color, string>
    {
        { Color.red, "Red" },
        { Color.green, "Green" },
        { Color.white, "White" }
    };

    public void ChooseMode(GameObject gameObject)
    {
        Color color = ChooseColorRandomly();
        _game.Init(new SingleColorPopStrategy(color));
        Debug.Log($"Requer target is {colorNames[color]}");
        gameObject.SetActive(false);
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
