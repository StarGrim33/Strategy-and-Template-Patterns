using System.Collections;
using UnityEngine;

public abstract class Weapon : MonoBehaviour, IWeapon
{
    [SerializeField] private SimpleBullet BulletPrefab;
    private float _shootForce = 10f;

    public virtual void PerformAttack()
    {
        var bullet = Instantiate(BulletPrefab);
        bullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * _shootForce, ForceMode.Impulse);
    }

    protected virtual IEnumerator Reloading() 
    {
        yield return null;
    }
}
