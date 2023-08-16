using UnityEngine;

public class ChooseGameModePopAllBall : MonoBehaviour
{
    [SerializeField] private Game _game;

    public void ChooseMode(GameObject gameObject)
    {
        _game.Init(new AllBallsPopStrategy());
        gameObject.SetActive(false);
    }
}
