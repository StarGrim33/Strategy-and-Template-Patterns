using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private List<Ball> _balls;
    [SerializeField] private List<Ball> _poppedBalls;

    private IVictory _iVictoryStrategy;

    public void Init(IVictory victoryStrategy)
    {
        _iVictoryStrategy = victoryStrategy;
    }

    public void BallsPoped(Ball ball)
    {
        _poppedBalls.Add(ball);
        ball.gameObject.SetActive(false);

        if (_iVictoryStrategy.CheckVictoryCondition(_balls, _poppedBalls))
            Debug.Log("You win");
    }
}
