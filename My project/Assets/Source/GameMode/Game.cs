using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Game : MonoBehaviour
{
    private List<Ball> _balls;
    private List<Ball> _poppedBalls;
    private IVictory _iVictoryStrategy;

    private void OnEnable()
    {
        foreach (var ball in _balls)
            ball.BallPopped += OnBallPopped;
    }

    [Inject]
    private void Construct(List<Ball> balls, IVictory victory)
    {
        _balls = balls;
        _poppedBalls = new List<Ball>();
        _iVictoryStrategy = victory;
    }

    private void OnBallPopped(Ball ball)
    {
        _poppedBalls.Add(ball);
        ball.BallPopped -= OnBallPopped;
        ball.gameObject.SetActive(false);
        BallsPoped();
    }

    public void BallsPoped()
    {
        if (_iVictoryStrategy.CheckVictoryCondition(_balls, _poppedBalls))
            Debug.Log("You win");
    }
}
