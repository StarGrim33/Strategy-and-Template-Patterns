using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    private List<IWeapon> _weapons;
    private IWeapon _currentWeapon;

    public void Init()
    {
        _weapons = new List<IWeapon> { gameObject.AddComponent<Pistol>(), gameObject.AddComponent<Shotgun>(), gameObject.AddComponent<InfiniteAmmoGun>() };
        _currentWeapon = _weapons[0];
        PerformShot();
    }

    private void PerformShot()
    {
        foreach (var weapon in _weapons)
        {
            weapon.PerformAttack();
        }
    }

    public void OnNextWeaponChange()
    {
        int currentIndex = _weapons.IndexOf(_currentWeapon);
        int nextIndex = (currentIndex + 1) % _weapons.Count;

        _currentWeapon = _weapons[nextIndex];

        Debug.Log($"Текущее оружие теперь {_currentWeapon.GetType()}");
    }
}
