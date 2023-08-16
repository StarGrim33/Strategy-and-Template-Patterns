using UnityEngine;

public class SimpleTrader : Trader
{
    protected override void Init()
    {
        _tradeable = new DisabledTrading();
    }
}
