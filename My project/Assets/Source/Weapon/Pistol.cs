using System.Collections;
using UnityEngine;

public class Pistol : Weapon
{
    private int _currentAmmo;
    private int _magazine = 8;
    private float _reloadingDelay = 2f;

    private void Start()
    {
        _currentAmmo = _magazine;
    }

    public override void PerformAttack()
    {
        if (_currentAmmo > 0 && _currentAmmo != 0)
        {
            base.PerformAttack();
            _currentAmmo--;
            Debug.Log("Pistol attacks}");
        }
        else
            StartCoroutine(Reloading());
    }

    protected override IEnumerator Reloading()
    {
        Debug.Log("Pistol Reloading...");
        var waitForSeconds = new WaitForSeconds(_reloadingDelay);
        yield return waitForSeconds;
        _currentAmmo = _magazine;
        Debug.Log("Pistol Reloaded");
    }
}
