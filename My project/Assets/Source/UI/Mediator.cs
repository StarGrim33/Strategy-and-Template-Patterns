using UnityEngine.Events;

public class Mediator
{
    public event UnityAction<IVictory> OnVictoryStrategyChosen;

    public void ChooseVictoryStrategy(IVictory victory)
    {
        OnVictoryStrategyChosen?.Invoke(victory);
    }
}
