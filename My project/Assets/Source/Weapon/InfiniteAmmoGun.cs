
using UnityEngine;

public class InfiniteAmmoGun : Weapon
{
    public override void PerformAttack()
    {
        base.PerformAttack();
        Debug.Log("InfiniteAmmoGun attacks");
    }
}
