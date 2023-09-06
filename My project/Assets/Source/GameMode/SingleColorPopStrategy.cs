using System.Collections.Generic;
using UnityEngine;

public class SingleColorPopStrategy : IVictory
{
    private Color _targetColor;

    public Color Color => _targetColor;

    public SingleColorPopStrategy(Color color)
    {
        _targetColor = color;
    }

    public bool CheckVictoryCondition(List<Ball> balls, List<Ball> poppedBalls)
    {
        List<Ball> remainingBallsOfTargetColor = balls.FindAll(ball => ball.Color == _targetColor);
        List<Ball> poppedBallsOfTargetColor = poppedBalls.FindAll(ball => ball.Color == _targetColor);

        return remainingBallsOfTargetColor.Count == poppedBallsOfTargetColor.Count;
    }
}
