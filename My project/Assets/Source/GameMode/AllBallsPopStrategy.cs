using System.Collections.Generic;
using UnityEngine;

public class AllBallsPopStrategy : IVictory
{
    public bool CheckVictoryCondition(List<Ball> balls, List<Ball> poppedBalls)
    {
        return poppedBalls.Count == balls.Count;
    }
}
