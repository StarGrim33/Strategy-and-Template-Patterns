using System.Collections.Generic;

public interface IVictory
{
    bool CheckVictoryCondition(List<Ball> balls, List<Ball> poppedBalls);
}
