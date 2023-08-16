using System.Collections;
using UnityEngine;

public abstract class Weapon : MonoBehaviour, IWeapon
{
    [SerializeField] private SimpleBullet _bulletPrefab;
    private float _shootForce = 10f;

    public virtual void PerformAttack()
    {
        var bullet = Instantiate(_bulletPrefab);
        bullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * _shootForce, ForceMode.Impulse);
    }

    protected virtual IEnumerator Reloading() 
    {
        yield return null;
    }
}
