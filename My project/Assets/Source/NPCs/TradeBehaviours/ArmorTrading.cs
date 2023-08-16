using UnityEngine;

public class ArmorTrading : ITradeable
{
    public void Trade(Player player)
    {
        Debug.Log("Player bought an armor");
    }
}
