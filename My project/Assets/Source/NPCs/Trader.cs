using UnityEngine;

public abstract class Trader : MonoBehaviour
{
    protected ITradeable _tradeable;

    private void Awake()
    {
        Init();
    }

    protected abstract void Init();

    protected void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Player>(out Player player))
        {
            if (player.Reputation == 1)
            {
                ChangeTradeBehavior(new FruitsTrading());
                Trade(player);
            }
            if (player.Reputation == 2)
            {
                ChangeTradeBehavior(new ArmorTrading());
                Trade(player);
            }
        }
    }

    public void Trade(Player player)
    {
        if (player != null)
            _tradeable.Trade(player);
    }

    public void ChangeTradeBehavior(ITradeable tradeBehaviour)
    {
        _tradeable = tradeBehaviour;
        Debug.Log($"New behaviour is {tradeBehaviour.ToString()}");
    }
}
