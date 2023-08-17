using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private List<Ball> _balls;
    [SerializeField] private List<Ball> _poppedBalls;

    private void OnEnable()
    {
        foreach (var ball in _balls)
            ball.BallPopped += OnBallPopped;
    }

    private void OnBallPopped(Ball ball)
    {
        _poppedBalls.Add(ball);
        ball.BallPopped -= OnBallPopped;
        ball.gameObject.SetActive(false);
        BallsPoped();
    }

    private IVictory _iVictoryStrategy;

    public void Init(IVictory victoryStrategy)
    {
        _iVictoryStrategy = victoryStrategy;
    }

    public void BallsPoped()
    {
        if (_iVictoryStrategy.CheckVictoryCondition(_balls, _poppedBalls))
            Debug.Log("You win");
    }
}
