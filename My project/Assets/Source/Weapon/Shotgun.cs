using System.Collections;
using UnityEngine;

public class Shotgun : Weapon
{
    private int _currentAmmo;
    private int _magazine = 12;
    private float _reloadingDelay = 2f;
    private int _bulletsPerShot = 3;

    private void Start()
    {
        _currentAmmo = _magazine;
    }

    public override void PerformAttack()
    {
        if (_currentAmmo > _bulletsPerShot && _currentAmmo != 0)
        {
            for (int i = 0; i < _bulletsPerShot; i++)
                base.PerformAttack();

            Debug.Log("Shotgun attacks");
            _currentAmmo -= _bulletsPerShot;
        }
        else if (_currentAmmo > 0)
        {
            for (int i = 0; i < _bulletsPerShot; i++)
                base.PerformAttack();

            _currentAmmo = 0;
        }
        else
            StartCoroutine(Reloading());
    }

    protected override IEnumerator Reloading()
    {
        Debug.Log("Reloading...");
        var waitForSeconds = new WaitForSeconds(_reloadingDelay);
        yield return waitForSeconds;
        _currentAmmo = _magazine;
        Debug.Log("Reloaded");
    }
}
